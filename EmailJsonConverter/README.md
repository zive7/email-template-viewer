# Email HTML to JSON Converter

A .NET 8 console application that converts HTML email templates to JSON format for notification engines.

## Purpose

This tool serializes HTML template files (e.g., `.html`, `.handlebars`) into a JSON object with a structured key format: `Notification.Engine.TemplateHtmlContent.<TemplateName>`.

## Features

- Interactive prompts for file paths and template names
- Command-line argument support for automation
- Automatic sanitization/serialization of HTML content
- Clean, formatted JSON output
- User-friendly error handling with retry capability
- Invalid file paths don't terminate the application - you can retry with corrected paths
- File size validation (max 10 MB) with detailed feedback

## Building the Application

```bash
dotnet build
```

## Usage

### Interactive Mode

Simply run the application and follow the prompts:

```bash
dotnet run
```

You'll be asked to provide:

1. **HTML file path** - Path to your HTML/Handlebars template file
2. **Template name** - Name for the template (defaults to filename without extension)
3. **Output file path** - Where to save the JSON (defaults to `output-templates/<filename>.json` in the application directory)

### Command-Line Mode

Provide the HTML file path as an argument:

```bash
dotnet run -- path/to/template.html
```

or

```bash
dotnet run -- "C:\Templates\WelcomeEmail.handlebars"
```

You'll still be prompted for the template name and output path.

## Examples

### Example 1: Basic Usage

```bash
dotnet run
```

```text
=== Email HTML to JSON Converter ===

Enter the HTML file path: TemplateHtmlContent.handlebars
✓ File found: TemplateHtmlContent.handlebars
✓ File size: 0.03 MB (within limit)

Enter template name (default: TemplateHtmlContent): WelcomeEmail
Template Name: WelcomeEmail
Created output directory: C:\Path\To\App\output-templates
Enter output file path (default: C:\Path\To\App\output-templates\TemplateHtmlContent.json): 
Output File: C:\Path\To\App\output-templates\TemplateHtmlContent.json

Reading HTML template...
Writing JSON file...

✓ Successfully converted 'TemplateHtmlContent.handlebars' to 'C:\Path\To\App\output-templates\TemplateHtmlContent.json'
✓ JSON key: Notification.Engine.TemplateHtmlContent.WelcomeEmail
```

### Example 2: With Command-Line Argument

```bash
dotnet run -- "../templates/ResetPassword.html"
```

### Example 3: Invalid File Path with Retry

```text
=== Email HTML to JSON Converter ===

✗ Error: File 'nonexistent.html' not found.

Please enter a valid HTML file path (or press Ctrl+C to exit): wrong-file.html
✗ Error: File 'wrong-file.html' not found.

Please enter a valid HTML file path (or press Ctrl+C to exit): sample-template.html
✓ File found: sample-template.html
✓ File size: 0.05 MB (within limit)

Enter template name (default: sample-template): MyTemplate
Template Name: MyTemplate
Created output directory: C:\Path\To\App\output-templates
Enter output file path (default: C:\Path\To\App\output-templates\sample-template.json): 
Output File: C:\Path\To\App\output-templates\sample-template.json

Reading HTML template...
Writing JSON file...

✓ Successfully converted 'sample-template.html' to 'C:\Path\To\App\output-templates\sample-template.json'
✓ JSON key: Notification.Engine.TemplateHtmlContent.MyTemplate
```

### Example 4: File Size Limit Exceeded

```text
=== Email HTML to JSON Converter ===

Enter the HTML file path: large-template.html
✗ Error: File size (15.43 MB) exceeds the maximum allowed size of 10 MB.

Please enter a valid HTML file path (or press Ctrl+C to exit):
```

### Example 5: Publishing as Executable

Create a standalone executable:

```bash
dotnet publish -c Release -r win-x64 --self-contained true
```

Then run directly:

```bash
.\bin\Release\net8.0\win-x64\publish\EmailJsonConverter.exe template.html
```

## Output Format

The generated JSON file will have the following structure:

```json
{
  "Notification.Engine.TemplateHtmlContent.TemplateName": "<entire HTML content as string>"
}
```

### Output Location

By default, all converted JSON files are saved to the `output-templates` folder within the application directory. The folder is automatically created if it doesn't exist. You can still specify a custom output path when prompted if needed.

## Requirements

- .NET 8.0 SDK
- Newtonsoft.Json (automatically restored via NuGet)

## Project Structure

```text
EmailJsonConverter/
├── EmailJsonConverter.csproj
├── Program.cs
└── README.md
```

## Error Handling

The application handles common errors:

- File not found
- Invalid file paths
- File size exceeds 10 MB limit
- Read/write permission issues
- Invalid JSON serialization

All errors are displayed with clear messages, and the application allows you to retry with a corrected file path instead of terminating.

## Tips

- Template names should not contain spaces or special characters for best compatibility
- The HTML content is automatically escaped and serialized safely
- Use `.handlebars`, `.html`, or any text-based template format
- Press Enter at any prompt to accept the default value

## License

This is a helper utility for internal use.

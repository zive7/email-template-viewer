# Email JSON Converter - Project Summary

## Overview

**EmailJsonConverter** is a .NET 8 console application that converts HTML email templates (including Handlebars templates) into JSON format for notification engines.

## What It Does

The application:
1. Reads an HTML template file
2. Creates a JSON object with the key format: `Notification.Engine.TemplateHtmlContent.<TemplateName>`
3. Serializes the HTML content as the value
4. Writes the formatted JSON to an output file

## Implementation

The application follows the exact pattern specified:

```csharp
var term = "Notification.Engine.TemplateHtmlContent.<Template Name>";
var template = File.ReadAllText(@"TemplateHtmlContent.handlebars");
var jsonFlat = new JObject();
jsonFlat.Add(term, template);
var json = JsonConvert.SerializeObject(jsonFlat);
File.WriteAllText(@"upload.json", json);
```

## Project Structure

```
EmailJsonConverter/
├── Program.cs              # Main application logic
├── EmailJsonConverter.csproj
├── README.md               # Full documentation
├── QUICKSTART.md          # Quick start guide
├── SUMMARY.md             # This file
├── sample-template.html   # Example template for testing
└── .gitignore            # Git ignore rules
```

## Key Features

✓ **Interactive Mode** - User-friendly prompts for all inputs  
✓ **Command-Line Arguments** - Support for automation  
✓ **Smart Defaults** - Uses filename as template name by default  
✓ **Clean Output** - Indented JSON for readability  
✓ **Error Handling** - Graceful handling of file errors  
✓ **Flexible Input** - Works with .html, .handlebars, or any text file  

## Technology Stack

- **.NET 8.0** - Latest LTS version
- **Newtonsoft.Json** - JSON serialization library
- **C#** - Programming language

## Usage Examples

### Basic Usage
```bash
cd EmailJsonConverter
dotnet run
```

### With File Argument
```bash
dotnet run -- path/to/template.html
```

### Testing with Sample
```bash
dotnet run -- sample-template.html
```

## Output Format

The generated JSON follows this structure:

```json
{
  "Notification.Engine.TemplateHtmlContent.TemplateName": "<!DOCTYPE html>..."
}
```

## Dependencies

- Newtonsoft.Json (v13.0.4) - Automatically restored via NuGet

## Build & Run

### Build
```bash
dotnet build
```

### Run
```bash
dotnet run
```

### Publish (Standalone Executable)
```bash
dotnet publish -c Release -r win-x64 --self-contained true
```

## Integration

This application is part of the `notification-email-template` solution and can be used alongside:
- **EmailTemplateViewer** - For previewing email templates

## Files Included

1. **Program.cs** - Main application with full implementation
2. **sample-template.html** - Example HTML email template with Handlebars placeholders
3. **README.md** - Comprehensive documentation
4. **QUICKSTART.md** - Quick start guide for immediate use
5. **.gitignore** - Configured to ignore build outputs and generated JSON files

## Workflow

```
[HTML Template] → [EmailJsonConverter] → [JSON Output] → [Notification Engine]
```

## Testing

A sample template is included for testing. Run:

```bash
dotnet run -- sample-template.html
```

This will generate `upload.json` with the properly formatted output.

## Success Criteria

✓ Reads HTML/Handlebars files  
✓ Sanitizes and serializes content correctly  
✓ Creates proper JSON structure with correct key format  
✓ Writes formatted JSON output  
✓ Handles errors gracefully  
✓ Provides interactive and automated modes  
✓ Includes comprehensive documentation  

## Next Steps

1. Use the application to convert your email templates
2. Upload the generated JSON to your notification engine
3. Customize the code if you need additional features (batch processing, etc.)

## Support

For issues or questions:
- Check the README.md for detailed documentation
- Review QUICKSTART.md for common usage patterns
- Examine the sample-template.html for reference

---

**Created**: October 3, 2025  
**Framework**: .NET 8.0  
**License**: Internal Helper Application


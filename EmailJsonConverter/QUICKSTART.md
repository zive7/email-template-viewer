# Quick Start Guide

## Run the Application

### Option 1: Interactive Mode (Recommended for first-time use)

```bash
cd EmailJsonConverter
dotnet run
```

Then follow the prompts!

### Option 2: With File Argument

```bash
cd EmailJsonConverter
dotnet run -- sample-template.html
```

### Option 3: Test with Sample Template

A `sample-template.html` file is included for testing:

```bash
cd EmailJsonConverter
dotnet run -- sample-template.html
```

When prompted:
- **Template name**: Press Enter to use `sample-template` or type a custom name like `WelcomeEmail`
- **Output path**: Press Enter to use `upload.json` or specify a custom path

## Expected Output

After running successfully, you'll see:

```
=== Email HTML to JSON Converter ===

Enter the HTML file path: sample-template.html
Template Name: sample-template
Enter template name (default: sample-template): 
Enter output file path (default: upload.json): 
Output File: upload.json

Reading HTML template...
Writing JSON file...

✓ Successfully converted 'sample-template.html' to 'upload.json'
✓ JSON key: Notification.Engine.TemplateHtmlContent.sample-template
```

A new `upload.json` file will be created containing your template in the proper JSON format.

## Example Code Pattern

This application implements the following pattern:

```csharp
var term = "Notification.Engine.TemplateHtmlContent.<Template Name>";
var template = File.ReadAllText(@"TemplateHtmlContent.handlebars");
var jsonFlat = new JObject();
jsonFlat.Add(term, template);
var json = JsonConvert.SerializeObject(jsonFlat);
File.WriteAllText(@"upload.json", json);
```

## Next Steps

1. Replace `sample-template.html` with your actual email template
2. Run the converter
3. Upload the generated `upload.json` to your notification engine

## Common Use Cases

### Converting a Handlebars Template

```bash
dotnet run -- path/to/template.handlebars
```

### Batch Processing (Future Enhancement)

Currently processes one file at a time. For batch processing, run the tool multiple times or create a shell script.

### Custom Output Naming

```bash
dotnet run -- mytemplate.html
# When prompted for output: mytemplate-converted.json
```


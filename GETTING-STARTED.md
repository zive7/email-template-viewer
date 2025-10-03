# Getting Started with Email Template Viewer

## 🎯 Overview

This Blazor application lets you preview SendGrid email templates in both mobile and desktop views instantly.

## ⚡ Running the Application

### Option 1: Command Line
```bash
cd EmailTemplateViewer
dotnet run
```

### Option 2: Visual Studio
1. Open `notification-email-template.sln`
2. Press F5 or click "Run"

### Option 3: Visual Studio Code
1. Open the `EmailTemplateViewer` folder
2. Press F5 or use the terminal to run `dotnet run`

## 🌐 Accessing the Application

After running, open your browser to:
- HTTPS: `https://localhost:5001`
- HTTP: `http://localhost:5000`

The exact URL will be displayed in the console when the app starts.

## 📝 How to Use

### Step 1: Start the Application
Run the command above and wait for it to start (usually 2-3 seconds).

### Step 2: Open Your Browser
Navigate to the localhost URL shown in the console.

### Step 3: Test with Sample Template
1. Open `EmailTemplateViewer/sample-email.html` in a text editor
2. Copy the entire HTML content
3. Paste it into the textarea on the left side of the app
4. Click the **"Update Preview"** button

### Step 4: View the Results
- **Mobile View** (375px) appears on the right - always visible
- Toggle **"Show Desktop View"** checkbox to see the desktop version (1200px)

### Step 5: Use Your Own Templates
Replace the sample HTML with your SendGrid template and click "Update Preview"

## 🎨 UI Features

### Left Panel (Input Section)
- **Textarea**: Paste your HTML here
- **Show Desktop View** checkbox: Toggle desktop preview on/off
- **Update Preview** button: Refresh the preview with new HTML

### Right Panel (Preview Section)
- **Mobile View**: iPhone-sized preview (375px × 667px) - always visible
- **Desktop View**: Desktop email client size (1200px) - optional

## 💡 Tips & Tricks

1. **Copy Complete HTML**: Include `<!DOCTYPE>`, `<html>`, `<head>`, and `<body>` tags
2. **Inline Styles Work Best**: Email templates should use inline styles
3. **Test Responsiveness**: Check both mobile and desktop views
4. **Large Templates**: The textarea auto-resizes for large HTML files
5. **Clear Preview**: Leave textarea empty and click "Update Preview" to clear

## 🔍 What You'll See

### Mobile View
- Simulates iPhone screen size
- Shows how emails appear on mobile devices
- Always visible on the right side
- Includes frame header showing "Mobile View" and dimensions

### Desktop View (Optional)
- Simulates desktop email client
- 1200px width (common email client width)
- Appears left of mobile view when enabled
- Includes frame header showing "Desktop View" and dimensions

## 🐛 Troubleshooting

### App Won't Start
- Ensure .NET 8 SDK is installed: `dotnet --version`
- Check if port 5001 is available
- Try running with: `dotnet run --urls "http://localhost:5050"`

### Preview Not Updating
- Make sure you clicked "Update Preview" button
- Check browser console for errors (F12)
- Verify HTML is valid

### Styles Not Showing
- Email templates should use inline styles or `<style>` tags in `<head>`
- External CSS links may not work in iframe preview
- Use absolute URLs for images

## 🚀 Advanced Usage

### Different Port
```bash
dotnet run --urls "http://localhost:8080"
```

### Production Build
```bash
dotnet publish -c Release
```

## 📊 Technical Details

- **Framework**: .NET 8 Blazor Server
- **Render Mode**: Interactive Server
- **Preview Method**: HTML iframe with `srcdoc` attribute
- **Responsive**: Layout adapts to screen size

## 🎯 Perfect For

✅ Testing SendGrid templates  
✅ Verifying responsive email design  
✅ Comparing mobile vs desktop rendering  
✅ Quick HTML email previews  
✅ Development workflow integration  

## 📧 Example Workflow

1. Design email template in HTML
2. Copy HTML to clipboard
3. Open Email Template Viewer
4. Paste HTML
5. Click "Update Preview"
6. Verify on mobile (always visible)
7. Toggle desktop view to check larger screens
8. Make adjustments and repeat

---

**Ready to start?** Run `cd EmailTemplateViewer && dotnet run` and open your browser!


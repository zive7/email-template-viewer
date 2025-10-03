# Quick Start Guide

## Running the Application

1. Open a terminal in the `EmailTemplateViewer` folder
2. Run the following command:
   ```bash
   dotnet run
   ```
3. Open your browser and navigate to the URL shown (usually `https://localhost:5001`)

## Testing with Sample Template

1. Open the `sample-email.html` file in this folder with a text editor
2. Copy the entire content
3. Paste it into the textarea in the application
4. Click "Update Preview"
5. Toggle "Show Desktop View" to see both mobile and desktop views

## Using Your SendGrid Templates

1. Copy your complete SendGrid HTML template
2. Paste it into the textarea
3. Click "Update Preview"
4. The mobile view (375px) is always visible on the right
5. Enable desktop view (1200px) using the checkbox to see side-by-side comparison

## Features

✅ **Mobile-First**: Mobile view is always visible  
✅ **Optional Desktop View**: Toggle desktop view on/off  
✅ **Live Preview**: See changes immediately  
✅ **Responsive**: Works on any screen size  
✅ **Clean UI**: No distractions, just your email preview

## Keyboard Shortcuts

- **Ctrl+Enter** (in textarea): Quick update preview (coming soon)
- **F11**: Full screen mode (browser native)

## Tips

- For best results, paste complete HTML documents (including `<!DOCTYPE>`, `<html>`, etc.)
- The iframe renders exactly as it would in an email client
- Mobile view uses iPhone-like dimensions (375px × 667px)
- Desktop view uses common email client width (1200px)


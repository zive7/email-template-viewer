# Email Template Viewer

A .NET 8 Blazor Server application for previewing SendGrid email templates in both mobile and desktop views.

## Features

- **Single Page Application**: Clean, focused interface for email template preview
- **Mobile View**: Always visible - shows how emails appear on mobile devices (375px width)
- **Desktop View**: Optional view - shows how emails appear on desktop (1200px width)
- **Live Preview**: Paste HTML and click "Update Preview" to see results
- **Modern UI**: Clean, professional interface with smooth interactions

## How to Use

1. **Run the application**:
   ```bash
   dotnet run
   ```

2. **Open your browser** and navigate to the URL shown in the console (typically `https://localhost:5001` or `http://localhost:5000`)

3. **Paste your SendGrid HTML template** in the textarea on the left side

4. **Check the "Show Desktop View" checkbox** if you want to see both desktop and mobile views side by side

5. **Click "Update Preview"** to render your HTML in the preview frames

## Project Structure

- `Components/Pages/Home.razor` - Main viewer page component
- `Components/Pages/Home.razor.css` - Scoped styles for the viewer
- `Components/Layout/MainLayout.razor` - Application layout (simplified)
- `wwwroot/app.css` - Global application styles

## Requirements

- .NET 8 SDK
- Modern web browser (Chrome, Edge, Firefox, Safari)

## Default Views

- **Mobile View**: 375px × 667px (iPhone-like dimensions) - Always visible
- **Desktop View**: 1200px wide - Optional, toggled via checkbox

## Tips

- The mobile view is always shown on the right side
- Desktop view appears to the left of mobile view when enabled
- On smaller screens, the layout automatically stacks vertically
- Use the browser's zoom if you need to see more detail


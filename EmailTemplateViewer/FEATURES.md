# Features & Capabilities

## ✨ Core Features

### 1. Mobile-First Preview
- **Always Visible**: Mobile view (375px × 667px) is permanently displayed
- **iPhone Dimensions**: Matches common mobile device size
- **Realistic Rendering**: Shows exactly how emails appear on mobile

### 2. Optional Desktop Preview
- **Toggle On/Off**: Enable desktop view via checkbox
- **Standard Width**: 1200px (common email client width)
- **Side-by-Side**: View mobile and desktop simultaneously

### 3. Live HTML Rendering
- **Real-Time Preview**: See changes immediately after clicking update
- **Full HTML Support**: Renders complete HTML documents
- **Iframe Isolation**: Preview runs in isolated iframe for safety

### 4. Clean User Interface
- **Single Page**: No navigation, no distractions
- **Intuitive Layout**: Input on left, previews on right
- **Responsive Design**: Works on any screen size

## 🎯 User Interface Components

### Input Section (Left Panel)
- **Large Textarea**: Accommodates full HTML templates
- **Syntax-Friendly Font**: Monospace font for code readability
- **Auto-Resize**: Textarea adjusts to content
- **Clear Labels**: Instructions and descriptions provided

### Preview Section (Right Panel)
- **Frame Headers**: Each preview shows view type and dimensions
- **Professional Styling**: Clean, modern frame design
- **Scrollable Content**: Long emails scroll within frames
- **Accurate Rendering**: Exact pixel dimensions

### Controls
- **Update Preview Button**: Large, prominent button
- **Desktop View Toggle**: Simple checkbox control
- **Visual Feedback**: Hover states and transitions

## 🔧 Technical Features

### Blazor Server Benefits
- **Interactive**: Real-time updates without page reload
- **Server-Side Rendering**: Fast initial load
- **State Management**: Maintains preview state
- **No JavaScript Required**: Pure C# logic

### Performance
- **Fast Rendering**: Immediate iframe updates
- **Efficient Updates**: Only re-renders when needed
- **Low Resource Usage**: Minimal server requirements
- **Responsive UI**: Smooth interactions

### Compatibility
- **Modern Browsers**: Works in Chrome, Edge, Firefox, Safari
- **Windows/Mac/Linux**: Cross-platform .NET 8
- **No Dependencies**: Self-contained application
- **Bootstrap 5**: Optional CSS framework included

## 📱 Preview Specifications

### Mobile View
- **Width**: 375px
- **Height**: 667px
- **Device**: iPhone-like dimensions
- **Always On**: Cannot be disabled
- **Position**: Right side (or bottom on small screens)

### Desktop View
- **Width**: 1200px
- **Height**: 800px
- **Optional**: Can be toggled on/off
- **Position**: Left of mobile (or top on small screens)

## 🎨 Design Features

### Visual Polish
- **Modern Color Scheme**: Purple accent color (#7c3aed)
- **Smooth Shadows**: Subtle depth with box shadows
- **Rounded Corners**: 8px border radius throughout
- **Clean Typography**: Segoe UI font family

### Responsive Behavior
- **Large Screens**: Side-by-side layout
- **Small Screens**: Stacked vertical layout
- **Adaptive Sizing**: Frames adjust to available space
- **Scrollable Areas**: Overflow handled gracefully

### Accessibility
- **Clear Labels**: All controls clearly labeled
- **Keyboard Support**: Standard keyboard navigation
- **High Contrast**: Readable text colors
- **Focus States**: Visual feedback for interactions

## 🚀 Workflow Features

### Quick Testing
1. Paste HTML → 2. Click Update → 3. View results
- **3 Steps**: Minimal friction
- **Instant Feedback**: See results immediately
- **Compare Views**: Mobile vs desktop side-by-side

### Iterative Design
- Copy template
- Paste and preview
- Make changes
- Re-paste and preview
- Repeat until perfect

### Team Collaboration
- **No Installation**: Just run and share URL
- **Live Updates**: Changes visible immediately
- **Consistent Preview**: Same rendering for all users
- **Screenshot Ready**: Easy to capture and share results

## 🔒 Safety Features

### Iframe Isolation
- **Sandboxed Rendering**: HTML runs in isolated context
- **No External Execution**: Scripts limited to iframe
- **Protected State**: Cannot affect main application

### Input Validation
- **Safe HTML Handling**: Proper escaping and rendering
- **No Server Processing**: HTML only rendered client-side
- **State Management**: Preview state isolated per session

## 📊 Use Cases

### Primary Uses
✅ Testing SendGrid email templates  
✅ Verifying responsive design  
✅ Checking mobile compatibility  
✅ Comparing device renderings  
✅ Quick HTML previews  

### Development Workflow
✅ Pre-send template verification  
✅ Design iteration  
✅ Client presentations  
✅ Quality assurance  
✅ Documentation screenshots  

### Team Benefits
✅ Consistent preview environment  
✅ No email sending required  
✅ Fast feedback loop  
✅ Easy to share and demonstrate  
✅ No external dependencies  

## 🎁 Additional Benefits

### No Database Required
- **Stateless**: No data persistence needed
- **Simple Deployment**: Just run the app
- **No Migration**: No database setup or maintenance

### Self-Contained
- **All in One**: Everything included
- **No External APIs**: Works offline
- **Bootstrap Included**: CSS framework bundled
- **Sample Template**: Test file included

### Developer Friendly
- **Clean Code**: Well-organized project structure
- **Comments**: Key areas documented
- **Standard Practices**: Follows .NET conventions
- **Easy to Modify**: Extend or customize as needed

## 🔮 Future Enhancement Ideas

- Auto-update preview on input (debounced)
- Save/load templates locally
- Export preview as screenshot
- Multiple device size presets
- Dark mode toggle
- Custom frame dimensions
- HTML syntax highlighting
- Template library
- Comparison mode (before/after)
- Email client simulation modes

---

**Current Version**: 1.0  
**Framework**: .NET 8 Blazor Server  
**License**: Internal Helper Tool


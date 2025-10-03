// Function to download a file with the given content
window.downloadFile = function (filename, content, contentType) {
    // Create a Blob from the content
    const blob = new Blob([content], { type: contentType });
    
    // Create a temporary URL for the Blob
    const url = window.URL.createObjectURL(blob);
    
    // Create a temporary anchor element and trigger the download
    const anchorElement = document.createElement('a');
    anchorElement.href = url;
    anchorElement.download = filename;
    anchorElement.style.display = 'none';
    
    document.body.appendChild(anchorElement);
    anchorElement.click();
    
    // Clean up
    document.body.removeChild(anchorElement);
    window.URL.revokeObjectURL(url);
};

// Function to format HTML with proper indentation
window.formatHtml = function (html) {
    if (!html || html.trim() === '') {
        return '';
    }

    let formatted = '';
    let indent = 0;
    const tab = '  '; // 2 spaces for indentation
    
    // Remove extra whitespace and normalize
    html = html.trim().replace(/>\s+</g, '><');
    
    // Split by tags
    const tokens = html.split(/(<[^>]+>)/g).filter(token => token.trim() !== '');
    
    tokens.forEach(token => {
        // Check if it's a tag
        if (token.match(/^<\/[\w\s]+>$/)) {
            // Closing tag
            indent = Math.max(0, indent - 1);
            formatted += tab.repeat(indent) + token + '\n';
        } else if (token.match(/^<[\w\s]+[^>]*>$/)) {
            // Opening tag
            const isSelfClosing = token.match(/\/>$/) || 
                                  token.match(/^<(area|base|br|col|embed|hr|img|input|link|meta|param|source|track|wbr)/i);
            
            formatted += tab.repeat(indent) + token + '\n';
            
            if (!isSelfClosing) {
                indent++;
            }
        } else {
            // Text content
            const trimmed = token.trim();
            if (trimmed !== '') {
                formatted += tab.repeat(indent) + trimmed + '\n';
            }
        }
    });
    
    return formatted.trim();
};


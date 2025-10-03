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


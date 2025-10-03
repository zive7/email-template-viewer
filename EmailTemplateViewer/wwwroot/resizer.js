let resizeData = {
    isResizing: false,
    startX: 0,
    startWidth: 0,
    componentReference: null
};

window.initializeResizer = function() {
    document.addEventListener('mousemove', handleMouseMove);
    document.addEventListener('mouseup', handleMouseUp);
};

window.startResize = function(startX, startWidth) {
    resizeData.isResizing = true;
    resizeData.startX = startX;
    resizeData.startWidth = startWidth;
    document.body.style.cursor = 'col-resize';
    document.body.style.userSelect = 'none';
};

function handleMouseMove(e) {
    if (resizeData.isResizing) {
        const delta = e.clientX - resizeData.startX;
        const newWidth = resizeData.startWidth + delta;
        const minWidth = 300;
        const maxWidth = window.innerWidth - 400;
        
        if (newWidth >= minWidth && newWidth <= maxWidth) {
            // Update the element directly for smooth resizing
            const inputSection = document.querySelector('.input-section');
            if (inputSection) {
                inputSection.style.flex = `0 0 ${newWidth}px`;
            }
        }
    }
}

function handleMouseUp() {
    if (resizeData.isResizing) {
        resizeData.isResizing = false;
        document.body.style.cursor = 'default';
        document.body.style.userSelect = '';
        
        // Get the final width and save it
        const inputSection = document.querySelector('.input-section');
        if (inputSection) {
            const finalWidth = inputSection.offsetWidth;
            // Optionally notify Blazor component of the final width
            if (window.DotNet) {
                DotNet.invokeMethodAsync('EmailTemplateViewer', 'UpdateWidth', finalWidth);
            }
        }
    }
}


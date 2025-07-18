import React, { StrictMode } from "react";
import { createRoot } from 'react-dom/client';
import Library from "./Library/Library";

function main() {
    let component = null;
    let targetContainer = null;
    // let mode;

    targetContainer = document.getElementById('library-component');
    component = <Library></Library>;

    if (!component || !targetContainer) {
        return;
    }

    const root = createRoot(targetContainer);
    root.render(
        <StrictMode>
            {component}
        </StrictMode>
    );
}

document.addEventListener('DOMContentLoaded', main);

import { JSX } from 'react';
import Library from './Library/Library';

export default function ComponentFactory(componentType: string): () => JSX.Element {
    switch (componentType) {
        case 'library':
            return Library;
        default:
            throw new Error("Invalid componentType provided");
    }
}

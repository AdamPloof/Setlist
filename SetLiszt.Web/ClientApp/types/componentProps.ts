import { Song } from "./entities"

export interface SongListProps {
    songs: Song[];
}

export interface SongViewerProps {
    song: Song | null;
}

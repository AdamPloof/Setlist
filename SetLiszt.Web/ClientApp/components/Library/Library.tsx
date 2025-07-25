import React, { JSX, useState, useEffect } from 'react';

import { Song } from '../../types/entities';
import { SongTableProps } from '../../types/componentProps';
import { fetchData } from '../../includes/utils';
import { URL_LIST_SONGS } from '../../includes/paths';

function songTransformer(data: any[]): Song[] {
    const songs: Song[] = data.map(d => {
        return {
            id: Number(d.id),
            title: String(d.title),
            artist: d.artist ?? null,
            filepath: d.filePath ?? null,
        };
    });

    return songs;
}

function SongTable({ songs }: SongTableProps): JSX.Element {
    return (
        <table className="table table-bordered table-striped">
            <thead>
                <tr>
                    <th scope='col'>Title</th>
                    <th scope='col'>Artist</th>
                </tr>
            </thead>
            <tbody>
                {songs.map(s => {
                    return (
                        <tr key={s.id}>
                            <td>{s.title}</td>
                            <td>{s.artist}</td>
                        </tr>
                    );
                })}
            </tbody>
        </table>
    );
}

function Loader(): JSX.Element {
    return (
        <div className="loader">Loading songs...</div>
    );
}

export default function Library(): JSX.Element {
    const [songs, setSongs] = useState<Song[]>([]);
    const [loading, setLoading] = useState<boolean>(false);
    const [error, setError] = useState<string | null>(null);

    useEffect(() => {
        fetchSongs();
    }, []);

    const fetchSongs = async () => {
        setLoading(true);

        try {
            const songList = await fetchData<Song>(URL_LIST_SONGS, songTransformer);
            setSongs([...songList]);
            setLoading(false);
        } catch (e) {
            console.error(e);
            setError('Unable to fetch song list. Please try again.');
            setLoading(false);
        }
    };

    return (
        <div className="library-wrapper w-100">
            {loading ? <Loader /> : <SongTable songs={songs} />}
        </div>
    );
}

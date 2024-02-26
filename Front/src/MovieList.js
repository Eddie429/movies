import React, { useState, useEffect } from 'react';
import axios from 'axios';

const MovieList = () => {
    const [movies, setMovies] = useState([]);

    useEffect(() => {
        axios.get('http://localhost:5285/movies')
            .then(response => {
                setMovies(response.data);
            })
            .catch(error => {
                console.error('Error fetching movies: ', error);
            });
    }, []);

    return (
        <div>
            <h2>List of Movies</h2>
            <ul>
                {movies.map(movie => (
                    <li key={movie.id}>
                        <strong>{movie.name}</strong> - {movie.country}
                    </li>
                ))}
            </ul>
        </div>
    );
};

export default MovieList;
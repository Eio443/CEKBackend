import React, { useEffect, useState } from 'react';
import './App.css';
import axios from 'axios';

function App() {
	const [courses, setCourses] = useState([]);

	useEffect(() => {
		axios.get('http://localhost:5000/api/courses').then(response => {
			console.log(response);
			setCourses(response.data);
			
		})
	}, [])

	return (
		<div className="App">
			<header className="App-header">
				<h1>The CEK Application</h1>
				<ul>
					{courses.map((course : any) => (
						<li key={course.id}>{course.tittle}</li>
					))}
				</ul>
			</header>
		</div>
	);
}

export default App;

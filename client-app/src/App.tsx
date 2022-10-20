import React, { useEffect, useState } from 'react';
import './App.css';
import axios from 'axios';
import Moment from 'moment';

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
						
							<div>
								<li key={course.id}>
									<p>Course Title: {course.title}</p>
									<p>Course Creator: {course.creator}</p>
									<p>Date: {Moment(course.date).format("MMMM Do YYYY ")}</p>
									
							    </li>
								<hr/>
						    </div>
					
					))}
				</ul>
			</header>
		</div>
	);
}

export default App;

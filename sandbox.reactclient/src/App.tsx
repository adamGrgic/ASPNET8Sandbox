import { useEffect, useState } from 'react';
import './App.css';
import Todo from './types/todo';
//interface Forecast {
//    date: string;
//    temperatureC: number;
//    temperatureF: number;
//    summary: string;
//}

function App() {
    // sample content
    const [todos, setTodos] = useState<Todo[]>();

    useEffect(() => {
        getTodos();
    }, []);

    const contents = todos === undefined
        ? <p><em>Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationreact">https://aka.ms/jspsintegrationreact</a> for more details.</em></p>
        : <table className="table table-striped" aria-labelledby="tabelLabel">
            <thead>
                <tr>
                    <th>Title</th>
                    <th>Description</th>
                    <th>Created Date</th>
                    <th>Completed Date</th>
                </tr>
            </thead>
            <tbody>
                {todos.map(todo =>
                    <tr key={todo.id}>
                        <td>{todo.title}</td>
                        <td>{todo.description}</td>
                        <td>{todo.createdDate.toString()}</td>
                        <td>{todo.completedDate.toString()}</td>
                        <button className="">test</button>
                    </tr>
                )}
            </tbody>
        </table>;

    return (
        <div>
            <h1>Sandbox React Application</h1>
            <div>{ contents}</div>
        </div>
    );

    // samplke function
    async function getTodos() {
        const response = await fetch('https://localhost:7108/api/Todo', {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json'
            }
        });
        const data = await response.json();
        console.log(data);
        setTodos(data);
    }
}

export default App;
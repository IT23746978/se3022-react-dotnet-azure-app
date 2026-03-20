import React, { useEffect, useState } from "react";

function App() {
  const [data, setData] = useState([]);

  useEffect(() => {
    fetch("http://localhost:5159/weatherforecast")
      .then((res) => res.json())
      .then((data) => setData(data))
      .catch((err) => console.error(err));
  }, []);

  return (
    <div>
      <h1>React Front-End</h1>
      <h2>Data from .NET API</h2>
      <ul>
        {data.map((item, index) => (
          <li key={index}>
            {item.date} - {item.temperatureC}°C - {item.summary}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;
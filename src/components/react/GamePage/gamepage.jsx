import { useState, useEffect } from "react";
// import "./gamepage.css";
// import { Code } from '@astrojs/starlight/components';
import { Code } from 'astro-expressive-code/components'

export default () => {
  const [sections, setSections] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await fetch(
          "https://raw.githubusercontent.com/XQuestCode/SplashkitGames/main/config.json"
        );
        const temp = await response.json();
        const data = temp.games;
        console.log(data);
        setSections(data);
      } catch (error) {
        console.error("Error fetching data:", error);
      }
    };

    fetchData();
  }, []);

return (
    <div className="game-page-container">
       
        {sections.map(
            ({ name, description, image, video, src, language, rating, command }) => (
                <div className="game-section" key={name}>
                    <h2 id={name.toLowerCase().replace(/\s/g, "-")}><a href={`#${name.toLowerCase().replace(/\s/g, "-")}`}>{name}</a></h2>
                    <h3>Description</h3>
                    <p>{description}</p>
                    <h3>Image</h3>
                    {image !== "" ? (
                        <img
                            className="game-image"
                            src={
                                image.startsWith("http")
                                    ? image
                                    : `https://raw.githubusercontent.com/XQuestCode/SplashkitGames/main/${src}/${image}`
                            }
                            alt={"Game image"}
                        />
                    ) : (
                        <img
                            className="game-image"
                src="https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/760bb8f8-3a05-4e44-be4d-6d1b2a6e5392/d1nno8d-364adddf-a168-44a1-b5e5-db7e2e779331.gif?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzc2MGJiOGY4LTNhMDUtNGU0NC1iZTRkLTZkMWIyYTZlNTM5MlwvZDFubm84ZC0zNjRhZGRkZi1hMTY4LTQ0YTEtYjVlNS1kYjdlMmU3NzkzMzEuZ2lmIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.SIYcpgo6CrC3ucFcFCIAxRYhR-hFZK_0_NJlE7Z_67I"
                alt="Placeholder"
              />
            )}
            
            <h3>Download</h3>
            <a
              href={`https://raw.githubusercontent.com/XQuestCode/SplashkitGames/main/${src}/game.zip`}
              className="download-button"
            >
              Download
            </a>
            <h3>Language</h3>
            <p>{language}</p>
            <h3>Rating</h3>
            <p>{rating}</p>
          </div>
        )
      )}
    </div>
  );
};
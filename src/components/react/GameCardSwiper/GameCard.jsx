import { useState, useEffect, useRef } from "react";
import {
  Navigation,
  Pagination,
  Scrollbar,
  A11y,
} from "swiper/modules";
import { Swiper, SwiperSlide } from "swiper/react";
import "swiper/css";
import "swiper/css/navigation";
import "swiper/css/pagination";
import "swiper/css/scrollbar";
import "swiper/css/effect-fade";
import "./swiperstyles.css";

export default () => {
  const [cards, setCards] = useState([]); // Cards state
  const swiperRef = useRef(null); // Reference to Swiper instance

  // Fetch the games data
  useEffect(() => {
    const fetchData = async () => {
      try {
        // Use an absolute path from the public folder
        const response = await fetch(
          `src/components/react/GameCardSwiper/games-config.json?cache-bust=${new Date().getTime()}`
        );
        if (!response.ok) {
          throw new Error(`HTTP error! status: ${response.status}`);
        }
        const configData = await response.json();
        console.log("Fetched games data:", configData);

        const featuredCards = configData.games
          .filter((game) => game.featured)
          .sort((a, b) => a.name.localeCompare(b.name));

        setCards(featuredCards);

        if (swiperRef.current) {
          swiperRef.current.update(); // Force Swiper to update after cards are loaded
          swiperRef.current.slideToLoop(0); // Start loop from the first slide
        }
      } catch (error) {
        console.error("Error fetching data:", error);
      }
    };

    fetchData();
  }, []);

  useEffect(() => {
    const handleResize = () => {
      if (swiperRef.current) {
        swiperRef.current.update(); // Trigger Swiper update on resize
      }
    };

    window.addEventListener("resize", handleResize);

    return () => {
      window.removeEventListener("resize", handleResize);
    };
  }, []);

  const cardSlots = cards.map(({ name, description, link }) => (
    <SwiperSlide key={name}>
      <a href={`games/${link}`} className="card-link">
        <div className="card gamecard">
          <img
            src={`/gifs/games-showcase/${link}-showcase.gif`}
            alt={`Image for ${name}`}
          />
          <h3>{name}</h3>
          <p>{description}</p>
        </div>
      </a>
    </SwiperSlide>
  ));

  return (
    <>
      {cards.length > 0 ? (
        <Swiper
          effect={"fade"}
          fadeEffect={{ crossFade: true }}
          grabCursor={true}
          loop={cards.length > 1} // Enable loop only if there are more than 1 slide
          slidesPerView={cards.length < 3 ? cards.length : 3} // Adjust slidesPerView based on number of cards
          pagination={{ clickable: true }}
          navigation={true}
          observer={true}
          observeParents={true}
          onSwiper={(swiper) => {
            swiperRef.current = swiper; // Store Swiper instance
          }}
          modules={[Navigation, Pagination, Scrollbar, A11y]}
          className="mySwiper"
          spaceBetween={35}
          breakpoints={{
            1200: {
              slidesPerView: cards.length < 3 ? cards.length : 3, // Handle dynamically
              spaceBetween: 30,
            },
            1024: {
              slidesPerView: cards.length < 2 ? cards.length : 2, // Handle dynamically
              spaceBetween: 20,
            },
            768: {
              slidesPerView: 1, // On smaller screens, show 1 card
              spaceBetween: 10,
            },
          }}
        >
          {cardSlots}
        </Swiper>
      ) : (
        <p>Loading...</p> // Show loading state before cards are fetched
      )}
    </>
  );
};

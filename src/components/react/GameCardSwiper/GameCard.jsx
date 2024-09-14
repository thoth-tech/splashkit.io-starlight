import { useState, useEffect, useRef } from "react";
import {
  Autoplay,
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
  const [cards, setCards] = useState([]);
  const swiperRef = useRef(null); // Reference to Swiper instance

  useEffect(() => {
    const fetchData = async () => {
      try {
        // Add a cache-busting query string using the current timestamp
        const response = await fetch(
          `/src/components/react/GameCardSwiper/games-config.json?cache-bust=${new Date().getTime()}`
        );
        if (!response.ok) {
          throw new Error(`HTTP error! status: ${response.status}`);
        }
        const configData = await response.json();
        console.log("Fetched games data:", configData); // Log the fetched data
        const featuredCards = configData.games
          .filter((game) => game.featured)
          .sort((a, b) => a.name.localeCompare(b.name));
        setCards(featuredCards);
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
      <Swiper
        effect={"fade"}
        fadeEffect={{
          crossFade: true,
        }}
        grabCursor={true}
        loop={true} // Enable loop to fix disappearing cards
        pagination={{ clickable: true }}
        navigation={true}
        onSwiper={(swiper) => {
          swiperRef.current = swiper; // Store the Swiper instance in ref
        }}
        modules={[Navigation, Pagination, Scrollbar, A11y]}
        className="mySwiper"
        spaceBetween={35}
        breakpoints={{
          1200: {
            slidesPerView: 3, // Show 3 slides for large desktops
            spaceBetween: 30,
          },
          1024: {
            slidesPerView: 2, // Show 2 slides for tablets
            spaceBetween: 20,
          },
          768: {
            slidesPerView: 1, // Show 1 slide for mobile screens
            spaceBetween: 10,
          },
        }}
      >
        {cardSlots}
      </Swiper>
    </>
  );
};

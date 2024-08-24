import { useState, useEffect } from "react";
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

import configData from "./games-config.json";

export default () => {
  const [cards, setCards] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const data = configData.games;
        // Filter games to include only those marked as featured
        const featuredCards = data
          .filter(game => game.featured)  // Filter based on the featured flag
          .sort((a, b) => a.name.localeCompare(b.name));  // Sort alphabetically by name
        console.log(featuredCards);
        setCards(featuredCards);
      } catch (error) {
        console.error("Error fetching data:", error);
      }
    };

    fetchData();
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
        loop={true}
        pagination={{ clickable: true }}
        navigation={true}
        modules={[Navigation, Pagination, Scrollbar, A11y]}
        className="mySwiper"
        slidesPerView={3}
        spaceBetween={35}
      >
        {cardSlots}
      </Swiper>
    </>
  );
};
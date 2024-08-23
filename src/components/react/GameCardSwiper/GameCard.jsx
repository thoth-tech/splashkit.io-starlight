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
        console.log(data);
        setCards(data);
      } catch (error) {
        console.error("Error fetching data:", error);
      }
    };

    fetchData();
  }, []);

  const cardSlots = cards.map(({ name, description, image }) => (
    <SwiperSlide key={name}>
      <div className="card gamecard">
        {image !== "" ? (
          <img src={image.startsWith("http") ? image : `https://raw.githubusercontent.com/XQuestCode/SplashkitGames/main/${src}/${image}`} alt={"Game image"} />
        ) : (
          <img
            src="https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/760bb8f8-3a05-4e44-be4d-6d1b2a6e5392/d1nno8d-364adddf-a168-44a1-b5e5-db7e2e779331.gif?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzc2MGJiOGY4LTNhMDUtNGU0NC1iZTRkLTZkMWIyYTZlNTM5MlwvZDFubm84ZC0zNjRhZGRkZi1hMTY4LTQ0YTEtYjVlNS1kYjdlMmU3NzkzMzEuZ2lmIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.SIYcpgo6CrC3ucFcFCIAxRYhR-hFZK_0_NJlE7Z_67I"
            alt="Placeholder"
          />
        )}
        <h3>{name}</h3>
        <p>{description}</p>
      </div>
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
        spaceBetween={50}
      >
        {cardSlots}
      </Swiper>
    </>
  );
};

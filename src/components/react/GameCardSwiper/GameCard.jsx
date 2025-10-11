import { useState, useEffect } from "react";
import { Navigation, Pagination, Scrollbar, A11y } from "swiper/modules";
import { Swiper, SwiperSlide } from "swiper/react";
import "swiper/css";
import "swiper/css/navigation";
import "swiper/css/pagination";
import "swiper/css/scrollbar";
import "swiper/css/effect-fade";
import "./swiperstyles.css";

export default () => {
  const [cards, setCards] = useState([]); // Cards state

  // Fetch the games data
  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await fetch(
          `/games-config.json?cache-bust=${new Date().getTime()}`
        );
        if (!response.ok) {
          throw new Error(`HTTP error! status: ${response.status}`);
        }
        const configData = await response.json();
        const featuredCards = configData.games
          .filter((game) => game.featured)
          .sort((a, b) => a.name.localeCompare(b.name));
        setCards(featuredCards);
      } catch (error) {
        console.error("Error fetching data:", error);
      }
    };

    fetchData();
  }, []); // Run only once when the component mounts

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
          grabCursor={false}
          loop={true}
          pagination={{ clickable: true }}
          navigation={true}
          observer={true}
          observeParents={true}
          virtual={false}
          modules={[Navigation, Pagination, Scrollbar, A11y]}
          className="mySwiper"
          spaceBetween={30}
          breakpoints={{
            992: {
              slidesPerView: Math.min(cards.length, 3), // Max 3 slides for large screens
              spaceBetween: 30,
            },
            768: {
              slidesPerView: Math.min(cards.length, 2), // Max 2 slides for medium screens
              spaceBetween: 30,
            },
            576: {
              slidesPerView: 1, // 1 slide for mobile devices
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

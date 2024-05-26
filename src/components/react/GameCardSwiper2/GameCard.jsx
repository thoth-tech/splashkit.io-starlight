// Import Swiper core and required modules
import {Autoplay, EffectCoverflow,  Navigation, Pagination, Scrollbar, A11y } from 'swiper/modules';
import { Swiper, SwiperSlide } from "swiper/react";

import "./swiperstyles.css";

// Import Swiper styles
import "swiper/css";
import "swiper/css/navigation";
import "swiper/css/pagination";
import "swiper/css/scrollbar";
import 'swiper/css/effect-fade';

export default () => {
  const cardSlots = [];
  

  const cards = [
    {
      title: "Game 1",
      description: "This is the description for Game 1.",
      imageUrl: "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/760bb8f8-3a05-4e44-be4d-6d1b2a6e5392/d1nno8d-364adddf-a168-44a1-b5e5-db7e2e779331.gif?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzc2MGJiOGY4LTNhMDUtNGU0NC1iZTRkLTZkMWIyYTZlNTM5MlwvZDFubm84ZC0zNjRhZGRkZi1hMTY4LTQ0YTEtYjVlNS1kYjdlMmU3NzkzMzEuZ2lmIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.SIYcpgo6CrC3ucFcFCIAxRYhR-hFZK_0_NJlE7Z_67I",
      altText: "Card 1 Image",
    },
    {
      title: "Game 2",
      description: "This is the description for Card 2.",
      imageUrl: "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/760bb8f8-3a05-4e44-be4d-6d1b2a6e5392/d1nno8d-364adddf-a168-44a1-b5e5-db7e2e779331.gif?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzc2MGJiOGY4LTNhMDUtNGU0NC1iZTRkLTZkMWIyYTZlNTM5MlwvZDFubm84ZC0zNjRhZGRkZi1hMTY4LTQ0YTEtYjVlNS1kYjdlMmU3NzkzMzEuZ2lmIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.SIYcpgo6CrC3ucFcFCIAxRYhR-hFZK_0_NJlE7Z_67I",
      altText: "Card 2 Image",
    },
    {
      title: "Game 3",
      description: "This is the description for Game 3.",
      imageUrl: "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/760bb8f8-3a05-4e44-be4d-6d1b2a6e5392/d1nno8d-364adddf-a168-44a1-b5e5-db7e2e779331.gif?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzc2MGJiOGY4LTNhMDUtNGU0NC1iZTRkLTZkMWIyYTZlNTM5MlwvZDFubm84ZC0zNjRhZGRkZi1hMTY4LTQ0YTEtYjVlNS1kYjdlMmU3NzkzMzEuZ2lmIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.SIYcpgo6CrC3ucFcFCIAxRYhR-hFZK_0_NJlE7Z_67I",
      altText: "Card 3 Image",
    },
    {
      title: "Game 4",
      description: "This is the description for Game 4.",
      imageUrl: "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/760bb8f8-3a05-4e44-be4d-6d1b2a6e5392/d1nno8d-364adddf-a168-44a1-b5e5-db7e2e779331.gif?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzc2MGJiOGY4LTNhMDUtNGU0NC1iZTRkLTZkMWIyYTZlNTM5MlwvZDFubm84ZC0zNjRhZGRkZi1hMTY4LTQ0YTEtYjVlNS1kYjdlMmU3NzkzMzEuZ2lmIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.SIYcpgo6CrC3ucFcFCIAxRYhR-hFZK_0_NJlE7Z_67I",
      altText: "Card 4 Image",
    },
  ];

  for (const card of cards) {
    const { title, description, imageUrl, altText } = card;

    cardSlots.push(
      <SwiperSlide key={title}>
        <div className="card gamecard2">
          <img src={imageUrl} alt={altText} />
          <h3>{title}</h3>
          <p>{description}</p>
        </div>
      </SwiperSlide>
    );
  }

  return (
    <>
      <Swiper
        effect={'coverflow'}
        fadeEffect={{
          crossFade: true,
        }}
        autoplay={{
          delay: 2500,
          disableOnInteraction: false,
        }}
        grabCursor={true}
        loop={true}
        coverflowEffect={{
          rotate: 50,
          stretch: 0,
          depth: 100,
          modifier: 1,
          slideShadows: true,
        }}
        pagination={{ clickable: true }}
        navigation={true}
        modules={[Autoplay, EffectCoverflow, Navigation, Pagination, Scrollbar, A11y]}
        
        className="mySwiper"
        slidesPerView={3} // Display 3 cards at a time
        spaceBetween={50} // Add spacing between cards
      >
        {cardSlots}
      </Swiper>
    </>
  );
}
import React from 'react';
import { Swiper, SwiperSlide } from 'swiper/react';
import { Navigation, Pagination, Autoplay } from 'swiper/modules';
import 'swiper/css';
import 'swiper/css/navigation';
import 'swiper/css/pagination';
import './swiperstyles.css';

const games = [
  {
    title: "Space Shooter",
    description: "A classic space shooter game built with SplashKit.",
    link: "/games/space-shooter",
    playable: true
  },
  {
    title: "Platformer Adventure",
    description: "Jump your way to victory in this platformer.",
    link: "/games/platformer",
    playable: false
  },
  {
    title: "Puzzle Master",
    description: "Solve complex puzzles using logic.",
    link: "/games/puzzle-master",
    playable: true
  }
];

export default function GameCardSwiper() {
  return (
    <div className="games-showcase-container">
      <Swiper
        modules={[Navigation, Pagination, Autoplay]}
        spaceBetween={30}
        slidesPerView={1}
        navigation
        pagination={{ clickable: true }}
        autoplay={{ delay: 5000 }}
        breakpoints={{
          640: {
            slidesPerView: 2,
          },
          1024: {
            slidesPerView: 3,
          },
        }}
        className="game-swiper"
      >
        {games.map((game, index) => (
          <SwiperSlide key={index}>
            <div className="game-card">
              <div className="game-card-content">
                <h3>{game.title}</h3>
                <p>{game.description}</p>
                <div className="game-card-actions">
                  <a href={game.link} className="sko-button">Read More</a>
                  {game.playable && (
                    <a href={game.link} className="sko-button">Try Game</a>
                  )}
                </div>
              </div>
            </div>
          </SwiperSlide>
        ))}
      </Swiper>
    </div>
  );
}

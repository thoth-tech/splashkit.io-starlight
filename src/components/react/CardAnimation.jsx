import { useEffect } from 'react';

const CardAnimation = () => {
  useEffect(() => {
    const handleOnMouseMove = (e) => {
      const { currentTarget: target } = e;

      if (!target) return;
      const rect = target.getBoundingClientRect(),
        x = e.clientX - rect.left,
        y = e.clientY - rect.top;

      target.style.setProperty("--mouse-x", `${x}px`);
      target.style.setProperty("--mouse-y", `${y}px`);
    };

    const cards = document.querySelectorAll(".card");
    cards.forEach((card) => {
      card.addEventListener("mousemove", handleOnMouseMove);
    });

    return () => {
      cards.forEach((card) => {
        card.removeEventListener("mousemove", handleOnMouseMove);
      });
    };
  }, []);

  return null;
};

export default CardAnimation;
// File: fill_circle_on_window-1-example-beyond.cpp

#include <SFML/Graphics.hpp>

int main()
{
    sf::RenderWindow window(sf::VideoMode(400, 400), "Fill Circle on Window");

    // Define a filled circle
    sf::CircleShape circle(50); // radius
    circle.setFillColor(sf::Color::Red);
    circle.setPosition(150, 150); // x, y

    while (window.isOpen())
    {
        sf::Event event;
        while (window.pollEvent(event))
        {
            if (event.type == sf::Event::Closed)
                window.close();
        }

        window.clear(sf::Color::White);
        window.draw(circle);
        window.display();
    }

    return 0;
}

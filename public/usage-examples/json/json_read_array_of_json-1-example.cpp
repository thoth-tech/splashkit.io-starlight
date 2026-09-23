#include "splashkit.h"

int main()
{
    // Build the Json from text, so the example needs no resource files
    json scores = json_from_string("{\"players\": [{\"name\": \"Ada\", \"score\": 120}, {\"name\": \"Grace\", \"score\": 95}, {\"name\": \"Linus\", \"score\": 140}]}");

    // Each entry in this list is a Json object of its own
    vector<json> players;
    json_read_array(scores, "players", players);

    int player_count = players.size();

    open_window("Score Board", 520, 360);

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        draw_text("Score board", COLOR_BLACK, "arial", 30, 30, 25);

        for (int index = 0; index < player_count; index++)
        {
            // Read the fields from each player like from any other Json object
            string player_name = json_read_string(players[index], "name");
            int player_score = json_read_number_as_int(players[index], "score");

            draw_text(player_name + ": " + std::to_string(player_score), COLOR_BLACK, "arial", 24, 30, 85 + index * 40);
        }

        refresh_screen(60);
    }

    // Frees the scores and the player objects that were read from it
    free_all_json();
    close_all_windows();
    return 0;
}

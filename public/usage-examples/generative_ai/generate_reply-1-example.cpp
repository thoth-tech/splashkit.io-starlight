#include "splashkit.h"

int main()
{
    open_window("Interactive AI Terminal", 900, 600);

    write_line("Interactive AI Terminal (Single-Turn)");
    write("Enter your prompt: ");
    string prompt = read_line();

    string reply = generate_reply(prompt);

    write_line("\nAI reply:");
    write_line(reply);

    while (!quit_requested())
    {
        process_events();

        clear_screen(COLOR_WHITE);
        draw_text("Interactive AI Terminal", COLOR_BLACK, 20, 20);
        draw_text("Prompt:", COLOR_BLACK, 20, 70);
        draw_text(prompt, COLOR_DARK_SLATE_GRAY, 20, 100);
        draw_text("AI Reply:", COLOR_BLACK, 20, 160);
        draw_text(reply, COLOR_BLUE, 20, 190);

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
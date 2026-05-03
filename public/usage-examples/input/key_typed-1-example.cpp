#include "splashkit.h"
#include <string>
#include <vector>

using namespace std;

int main()
{
    open_window("Last Typed Key", 800, 600);

    vector<key_code> tracked_keys = {
        A_KEY, B_KEY, C_KEY, D_KEY, E_KEY, F_KEY, G_KEY, H_KEY, I_KEY, J_KEY,
        K_KEY, L_KEY, M_KEY, N_KEY, O_KEY, P_KEY, Q_KEY, R_KEY, S_KEY, T_KEY,
        U_KEY, V_KEY, W_KEY, X_KEY, Y_KEY, Z_KEY,
        NUM_0_KEY, NUM_1_KEY, NUM_2_KEY, NUM_3_KEY, NUM_4_KEY,
        NUM_5_KEY, NUM_6_KEY, NUM_7_KEY, NUM_8_KEY, NUM_9_KEY,
        SPACE_KEY, ESCAPE_KEY
    };

    string last_key = "None";

    while (!quit_requested())
    {
        process_events();

        // Update the text when a supported key is typed
        for (key_code key : tracked_keys)
        {
            if (key_typed(key))
            {
                last_key = key_name(key);
            }
        }

        clear_screen(COLOR_WHITE);

        draw_text("Press a supported key", COLOR_BLACK, 20, 20);
        draw_text("Last typed: " + last_key, COLOR_BLUE, 20, 80);

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
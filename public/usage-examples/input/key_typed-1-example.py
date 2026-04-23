from splashkit import *

tracked_keys = [
    KeyCode.a_key, KeyCode.b_key, KeyCode.c_key, KeyCode.d_key, KeyCode.e_key,
    KeyCode.f_key, KeyCode.g_key, KeyCode.h_key, KeyCode.i_key, KeyCode.j_key,
    KeyCode.k_key, KeyCode.l_key, KeyCode.m_key, KeyCode.n_key, KeyCode.o_key,
    KeyCode.p_key, KeyCode.q_key, KeyCode.r_key, KeyCode.s_key, KeyCode.t_key,
    KeyCode.u_key, KeyCode.v_key, KeyCode.w_key, KeyCode.x_key, KeyCode.y_key, KeyCode.z_key,
    KeyCode.num_0_key, KeyCode.num_1_key, KeyCode.num_2_key, KeyCode.num_3_key, KeyCode.num_4_key,
    KeyCode.num_5_key, KeyCode.num_6_key, KeyCode.num_7_key, KeyCode.num_8_key, KeyCode.num_9_key,
    KeyCode.space_key, KeyCode.escape_key
]

last_key = "None"

open_window("Last Typed Key", 800, 600)

while not quit_requested():
    process_events()

    # Update the text when a supported key is typed
    for key in tracked_keys:
        if key_typed(key):
            last_key = key_name(key)

    clear_screen(color_white())

    draw_text_no_font_no_size("Press a supported key", color_black(), 20, 20)
    draw_text_no_font_no_size("Last typed: " + last_key, color_blue(), 20, 80)

    refresh_screen()

close_all_windows()
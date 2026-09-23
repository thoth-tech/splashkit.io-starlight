#include "splashkit.h"

int main()
{
    conversation study_conversation = create_conversation();
    conversation travel_conversation = create_conversation();
    conversation coding_conversation = create_conversation();

    (void)study_conversation;
    (void)travel_conversation;
    (void)coding_conversation;

    write_line("Three AI conversations have been created:");
    write_line("- Study assistant");
    write_line("- Travel assistant");
    write_line("- Coding assistant");
    write_line("");

    write_line("Freeing all loaded conversations...");

    free_all_conversations();

    write_line("All conversation resources have been released.");

    return 0;
}
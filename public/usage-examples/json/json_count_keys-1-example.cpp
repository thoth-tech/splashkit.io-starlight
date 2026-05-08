#include "splashkit.h"
#include <iostream>

using namespace std;

int main()
{
    json j = create_json();

    json_set_string(j, "name", "Alex");
    json_set_string(j, "score", "95");
    json_set_string(j, "level", "3");

    cout << "Top-level key count: " << json_count_keys(j) << endl;

    return 0;
}
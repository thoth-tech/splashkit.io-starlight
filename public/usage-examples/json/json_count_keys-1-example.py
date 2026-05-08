from splashkit import *

j = create_json()

json_set_string(j, "name", "Alex")
json_set_string(j, "score", "95")
json_set_string(j, "level", "3")

print(f"Top-level key count: {json_count_keys(j)}")
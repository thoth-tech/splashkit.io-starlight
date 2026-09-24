from splashkit import *

raw_json = '{"player":"Avery","level":5,"status":"ready"}'

player_data = json_from_string(raw_json)
json_text = json_to_string(player_data)

write_line("Original JSON string:")
write_line(raw_json)
write_line("")
write_line("JSON object converted back to string:")
write_line(json_text)

free_json(player_data)
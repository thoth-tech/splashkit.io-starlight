from splashkit import *

example_json = create_json()

json_set_string(example_json, "name", "SplashKit")

has_name = json_has_key(example_json, "name")
has_age = json_has_key(example_json, "age")

write_line("JSON Has Key Example")
write_line("--------------------")

if has_name:
    write_line("Has key 'name': true")
else:
    write_line("Has key 'name': false")

if has_age:
    write_line("Has key 'age': true")
else:
    write_line("Has key 'age': false")

free_json(example_json)
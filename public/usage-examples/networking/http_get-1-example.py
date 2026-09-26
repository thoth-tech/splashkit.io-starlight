from splashkit import *


url = "http://example.com"
port = 80

print("HTTP GET Request")
print()
print("Requesting: " + url)
print()

# Make a GET request to the web resource
response = http_get(url, port)

# Convert the response into text
response_text = http_response_to_string(response)

print("Response received:")
print(response_text[:200])

# Release the HTTP response
free_response(response)
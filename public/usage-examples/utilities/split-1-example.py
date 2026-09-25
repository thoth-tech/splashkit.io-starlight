from splashkit import *

# Split a CSV string by comma
csv = "apple,banana,cherry,date"
parts = split(csv, ',')
write_line("Split 'apple,banana,cherry,date' by ',':")
for i in range(len(parts)):
    write_line("  [" + str(i) + "] " + parts[i])

# Split a sentence by space
sentence = "Hello World SplashKit"
words = split(sentence, ' ')
write_line("Split 'Hello World SplashKit' by ' ':")
for i in range(len(words)):
    write_line("  [" + str(i) + "] " + words[i])

# Split a path by slash
path = "home/user/documents"
folders = split(path, '/')
write_line("Split 'home/user/documents' by '/':")
for i in range(len(folders)):
    write_line("  [" + str(i) + "] " + folders[i])

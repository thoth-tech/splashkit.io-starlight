from splashkit import *

study_conversation = create_conversation()
travel_conversation = create_conversation()
coding_conversation = create_conversation()

print("Three AI conversations have been created:")
print("- Study assistant")
print("- Travel assistant")
print("- Coding assistant")
print()

print("Freeing all loaded conversations...")

free_all_conversations()

print("All conversation resources have been released.")
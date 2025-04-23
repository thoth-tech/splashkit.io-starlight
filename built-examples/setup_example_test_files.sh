#!/bin/bash

FILE_NAME=$1
FILE_PATH=`find ~+/../public/usage-examples -type f -name "${FILE_NAME}"`
GLOBAL_NAME="${FILE_NAME%%.*}"
FILE_TYPE="${FILE_NAME#*-example}"

cd ../built-examples/

mkdir -p "$GLOBAL_NAME"

cd "$GLOBAL_NAME"

# Check which file is being tested
if [[ "${FILE_TYPE}" = "-oop.cs" || "${FILE_TYPE}" = "-top-level.cs" ]]; then
    CSHARP=true
    TEST_DIR_NAME="CSharp_Testing"
    echo "Testing C# Example code"
elif [[ "${FILE_TYPE}" = "-sk.cpp" || "${FILE_TYPE}" = ".cpp" ]]; then
    CPP=true
    TEST_DIR_NAME="Cpp_Testing"
    echo "Testing C++ Example code"
elif [ "${FILE_TYPE}" = ".py" ]; then
    PYTHON=true
    TEST_DIR_NAME="Python_Testing"
    echo "Testing Python Example code"
fi

# Set up testing folder
if [ ! -d "${TEST_DIR_NAME}" ]; then
    mkdir -p "${TEST_DIR_NAME}"
fi
cd "${TEST_DIR_NAME}"

# Set up testing files
if [ "${CSHARP}" ]; then
    if [ ! -f "Program.cs" ]; then
        dotnet new console
        dotnet add package splashkit
    fi
elif [ "${CPP}" ]; then
    touch program.cpp
elif [ "${FILE_TYPE}" = ".py" ]; then
    touch program.py
fi

# Copy example code to test file
if [ "${CSHARP}" ]; then
    cat $FILE_PATH > ./Program.cs
elif [ "${CPP}" ]; then
    cat $FILE_PATH > ./program.cpp
elif [ "${FILE_TYPE}" = ".py" ]; then
    cat $FILE_PATH > ./program.py
fi

# Copy resources if found
RESOURCES_PATH="${FILE_PATH%%$FILE_TYPE*}-resources.zip"
if [ -f "${RESOURCES_PATH}" ]; then
    unzip -n "$RESOURCES_PATH" -d .
fi

# Compile example code for C# and C++
if [ "${CSHARP}" ]; then
    dotnet build
elif [ "${CPP}" ]; then
    clang++ program.cpp -l SplashKit -o test
fi
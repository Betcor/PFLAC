#!/bin/bash

base_dir=$(find . -type d -name "PFLAC" -print -quit)
file_name=".env.prod"

if [ -d "$base_dir" ]; then
    echo "Directory '$base_dir' found."

    if [ -f "$base_dir/$file_name" ]; then
        echo "Found .env.prod file at: $base_dir/$file_name"
    else
        echo ".env.prod file is missing in the directory."
    fi
else
    echo "Directory '$base_dir' not found in the current path."
fi

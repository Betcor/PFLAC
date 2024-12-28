#!/bin/bash

sudo service mysql status > /dev/null 2>&1

if [ $? != 0]; then
	sudo service mysql restart
fi

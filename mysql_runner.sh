#!/bin/bash

sudo service mysql status > /dev/null 2>&1
sudo service mysql start > /dev/null 2>&1

if [ $? != 0 ]; then
    sudo service mysql restart
fi

LOCAL_IP=$(hostname -I | awk '{print $1}')

if [ -z "$LOCAL_IP" ]; then
    echo "Failed to get the local IP address."
    exit 1
fi

sudo sed -i "s/^bind-address\s*=.*/bind-address = $LOCAL_IP/" /etc/mysql/my.cnf
sudo systemctl restart mysql

echo "MySQL is configured to bind to the IP: $LOCAL_IP"

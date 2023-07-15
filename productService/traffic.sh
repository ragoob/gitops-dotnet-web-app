#!/bin/bash

for ((i=1; i<=1000; i++))
do
    curl -k -X GET https://argocd.ragab.blog
done
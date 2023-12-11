#!/bin/bash
IMAGE_NAME=desafiopoo

# build Docker image
docker build -t $IMAGE_NAME .

# run docker image
docker run -it --rm $IMAGE_NAME
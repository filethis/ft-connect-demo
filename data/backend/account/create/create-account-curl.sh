#!/usr/bin/env bash

## Create account
curl -X "POST" "https://filethis.com/api/v1/accounts" \
     -H "Content-Type: text/plain; charset=utf-8" \
     -u s92htpkp9j19csri9a7hpc8mp:k6ndg9v9e8jt7e4n4td9oh0eue \
     -d $'{
  "partnerAccountId": "73ae0c1c-7a0d-4c2f-825e-64c9a9a7e1bd"
}'

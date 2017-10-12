#!/usr/bin/env bash

## Create account
curl -X "POST" "https://filethis.com/api/v1/accounts" \
     -H "Content-Type: text/plain; charset=utf-8" \
     -u xxx:yyy \
     -d $'{
  "partnerAccountId": "c4e1ae2d-5571-40d2-adab-4a8cb565204b"
}'

#!/usr/bin/env bash

http --form POST 'https://filethis.com/api/v1/accounts' \
    'Authorization':'Basic czkyaHRwa3A5ajE5Y3NyaTlhN2hwYzhtcDprNm5kZzl2OWU4anQ3ZTRuNHRkOW9oMGV1ZQ==' \
    'Content-Type':'text/plain; charset=utf-8' \
    'data'=$'{
  \"partnerAccountId\": \"fee2d78f-5fac-4e8a-b281-ad417b010665\"
}'



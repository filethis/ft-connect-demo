# Install the Python Requests library:
# `pip install requests`

import requests


def send_request():
    # Create account
    # POST https://filethis.com/api/v1/accounts

    try:
        response = requests.post(
            url="https://filethis.com/api/v1/accounts",
            headers={
                "Authorization": "Basic xxxxxxxxxxxxxx==",
                "Content-Type": "text/plain; charset=utf-8",
            },
            data="{
  \"partnerAccountId\": \"b642421c-e4d6-4a58-b263-a0548a9468e6\"
}"
        )
        print('Response HTTP Status Code: {status_code}'.format(
            status_code=response.status_code))
        print('Response HTTP Response Body: {content}'.format(
            content=response.content))
    except requests.exceptions.RequestException:
        print('HTTP Request failed')



package main

import (
	"fmt"
	"io/ioutil"
	"net/http"
	"strings"
)

func sendCreateAccount() {
	// Create account (POST https://filethis.com/api/v1/accounts)

	body := strings.NewReader(`{
  "partnerAccountId": "069b6ecd-ff14-4fdc-a139-27b2de6fdd46"
}`)

	// Create client
	client := &http.Client{}

	// Create request
	req, err := http.NewRequest("POST", "https://filethis.com/api/v1/accounts", body)

	// Headers
	req.Header.Add("Authorization", "Basic czkyaHRwa3A5ajE5Y3NyaTlhN2hwYzhtcDprNm5kZzl2OWU4anQ3ZTRuNHRkOW9oMGV1ZQ==")
	req.Header.Add("Content-Type", "text/plain; charset=utf-8")

	// Fetch Request
	resp, err := client.Do(req)

	if err != nil {
		fmt.Println("Failure : ", err)
	}

	// Read Response Body
	respBody, _ := ioutil.ReadAll(resp.Body)

	// Display Results
	fmt.Println("response Status : ", resp.Status)
	fmt.Println("response Headers : ", resp.Header)
	fmt.Println("response Body : ", string(respBody))
}



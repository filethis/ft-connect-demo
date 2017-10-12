// Create account (POST https://filethis.com/api/v1/accounts)

jQuery.ajax({
    url: "https://filethis.com/api/v1/accounts",
    type: "POST",
    headers: {
        "Authorization": "Basic xxxxxx==",
        "Content-Type": "text/plain; charset=utf-8",
    },
    processData: false,
    data: "{
  \"partnerAccountId\": \"f8b70f3d-5418-4d8e-8863-27c23039b149\"
}",
})
.done(function(data, textStatus, jqXHR) {
    console.log("HTTP Request Succeeded: " + jqXHR.status);
    console.log(data);
})
.fail(function(jqXHR, textStatus, errorThrown) {
    console.log("HTTP Request Failed");
})
.always(function() {
    /* ... */
});



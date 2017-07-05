function registrationUser() {
    $.ajax({
        url: 'AuthorizationUser',
        type: "POST",
        //   data: { id: parseInt(event.value) },
        success: function (response) {

            alert(response);

        }



    });
}
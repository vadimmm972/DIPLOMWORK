window.onload = function()
{
    $(".regionClass").css('display', 'none');
    $(".sityClass").css('display', 'none');
    getCountries();
}


function getCountries() {

    $.ajax({
        url: 'Base/GetCountries',
        type: "POST",
        //  processData: false,
        // contentType: false,
        success: function (response) {

            var regSelect = document.getElementById("country");
            for (var i = 0; i < response.length; i++) {
                var option = document.createElement("option");
                option.text = response[i].NameCountry;
                option.value = response[i].idCountry;
                regSelect.add(option);
            }

            $('.classRegion').css('display', 'block');
        },
        error: function (e) {

        }
    });
}


function getRegion(event) {
    var idCountry = event.value;
    $.ajax({
        url: 'Base/GetRegions',
        type: "POST",
        data:{id:idCountry},
        //  processData: false,
        // contentType: false,
        success: function (response) {

            var regSelect = document.getElementById("region");
            for (var i = 0; i < response.length; i++) {
                var option = document.createElement("option");
                option.text = response[i].NameRegion;
                option.value = response[i].idRegion;
                regSelect.add(option);
            }

            $(".regionClass").css('display', 'block');
        },
        error: function (e) {

        }
    });
}


function getСity(event) {
    var idRegion = event.value;

    $.ajax({
        url: 'Base/GetCity',
        type: "POST",
        data: { id: idCountry },
        //  processData: false,
        // contentType: false,
        success: function (response) {

            var regSelect = document.getElementById("region");
            for (var i = 0; i < response.length; i++) {
                var option = document.createElement("option");
                option.text = response[i].NameRegion;
                option.value = response[i].idRegion;
                regSelect.add(option);
            }

            $(".regionClass").css('display', 'block');
        },
        error: function (e) {

        }
    });
}


function registrationUser() {

    var surname = $("#surname").val();;
    var name = $("#name").val();;
    var lastname = $("#lastname").val();;
    var phone = $("#phone").val();;
    var email = $("#email").val();;
    var login = $("#login").val();;
    var password = $("#password").val();
    var confirmPass = $("#confirmPassword").val();
    var idCountry = $("#password").val();;
    var idrefion = $("#password").val();;
    var idSity = $("#password").val();;
   
    if (password !== confirmPass) {
        alert("Different passwords");
    }
    else {
        var imageName = UploadImage(2);
        $.ajax({
            url: 'AuthorizationUser',
            type: "POST",
            //   data: { id: parseInt(event.value) },
            success: function (response) {

                alert(response);

            }
        });
    }


}



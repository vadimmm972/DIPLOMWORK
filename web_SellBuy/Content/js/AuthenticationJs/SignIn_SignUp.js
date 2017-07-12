var checkIdCountry = 0;
var checkIdRegion = 0;
var checkIdCity = 0;

window.onload = function ()
{
    var url = window.location.href;
    var test = url.indexOf("SignIn")
    if (test == -1) {
        $(".regionClass").css('display', 'none');
        $(".sityClass").css('display', 'none');
        getCountries();
    }
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
    checkIdCountry = idCountry;
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


function getCity(event) {
    var idRegion = event.value;
    checkIdRegion = idRegion;
    $.ajax({
        url: 'Base/GetCity',
        type: "POST",
        data: { id: idRegion },
        //  processData: false,
        // contentType: false,
        success: function (response) {

            var regSelect = document.getElementById("city");
            for (var i = 0; i < response.length; i++) {
                var option = document.createElement("option");
                option.text = response[i].NameCity;
                option.value = response[i].idCity;
                regSelect.add(option);
            }

            $(".sityClass").css('display', 'block');
        },
        error: function (e) {

        }
    });
}


function getIdCity(event) {
    checkIdCity = event.value;
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
        alert("Пароли не совпадают");
    }
    else {
        //var imageName = UploadImage(2);
        if (imageName == "") {
            alert("Загрузите изображения");
        }
        else {
            $.ajax({
                url: 'AuthorizationUser',
                type: "POST",
                data: { _surname: surname, _name: name, _lastname: lastname, _phone: phone, _email: email, _login: login, _password: password, _idCountry: checkIdCountry, _idRegion: checkIdRegion, _idCity: checkIdCity, _photo: imageName },
                success: function (response) {
                    if (response != "") {
                        alert(response);
                    }
                    else {
                        window.location.href = "SignIn";
                    }
                }
            });
        }
        
    }


}



function SignIn() {

    var login = $("#Sign_login").val();
    var password = $("#Sign_password").val();

    $.ajax({
        url: 'Authentication/SignInUser',
        type: "POST",
        data: { _login:login , _password:password},
        success: function (response) {
            if (response != "success") {
                alert(response);
            }
            else {
                window.location.href = "Home";
            }
        }
    });
}



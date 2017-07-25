window.onload = function () {
    LoadInfoUserProfileAtTheContent();
}

var copySurname = "";
var copyName = "";
var copyLastname = "";
var copyPhone = "";
var copyMail = "";
var copyLogin = "";
var copyPass = "";
myelem = 0;

function LoadInfoUserProfileAtTheContent() {
    $.ajax({
        url: 'UserProfile/LoadUserInfo',
        type: "POST",
        processData: false,
        contentType: false,
        success: function (response) {
            if(response != null){
                $("#infoP_surname").val(response.Surname);
                copySurname = response.Surname;

                $("#infoP_name").val(response.Name);
                copyName = response.Name;

                $("#infoP_lastname").val(response.LastName);
                copyLastname = response.LastName;

                $("#infoP_phone").val(response.Phone);
                copyPhone = response.Phone;

                $("#infoP_mail").val(response.Mail);
                copyMail = response.Mail;

                $("#infoP_login").val(response.Login);
                copyLogin = response.Login;

                $(".imgcssProfileUpdate ").attr('src', '' + response.Image + '');
              
                $("#infoP_password").val("&#9913;&#9913;&#9913;");
            
            }
            else {
                alert("Ошыбка обратитесь к администратору сайта")
            }
        }
    });
}


function UpdateInfoProfileParam(param) {
    var newInfoParam = "";
    var errorParam = "";
    var errorString = "Вы не можете измень одинаковые значения";
    if (param == 1) {
        //updateSurname();
        newInfoParam = $("#infoP_surname").val();
        if (newInfoParam == copySurname) {
            errorParam = errorString;
        }
        else {
            copySurname = newInfoParam;
        }
    }
    else if (param == 2) {
        newInfoParam = $("#infoP_name").val();
        if (copyName == newInfoParam) {
            errorParam = errorString;
        }
        else {
            copyName = newInfoParam;
        }
    }

    if (errorParam == "" && newInfoParam != "") {
        $.ajax({
            url: 'UserProfile/UpdateInfoMyProfileInParam',
            type: "POST",
            data: { _idparam: param, newInfo: newInfoParam },
            success: function (response) {
                // alert(response);
                opendialog(response);
            }
        });
    }
    else{
        if (newInfoParam == "") {
            errorParam = "Поле не может быть пустым";
        }
        opendialog(errorParam);
    }

    
}

function updateNameUser() {
    var Name = $("#infoP_name").val();
    if (Name != "") {
        if (copyName != Name) {
            $.ajax({
                url: 'UserProfile/UpdateInfoMyProfileInParam',
                type: "POST",
                data: { _idparam: 2, newInfo: Name },
                success: function (response) {
                    // alert(response);
                    opendialog(response);
                }
            });
        }
        else {
            opendialog("Вы не можете переименовать имя на тоже самое");
        }
    }
    else {
        opendialog("Поле не может быть пустым");
    }
}

function updateSurname() {

    var SurName = $("#infoP_surname").val();


    if (SurName != "") {
        if (copySurname != SurName) {
            $.ajax({
                url: 'UserProfile/UpdateInfoMyProfileInParam',
                type: "POST",
                data: { _idparam: 1, newInfo: SurName },
                success: function (response) {
                   // alert(response);
                    opendialog(response);
                }
            });
        }
        else {
                opendialog("Вы не можете переименовать имя на тоже самое");
        }
    }
    else {
        opendialog("Поле не может быть пустым");
    } 

}

function updateLastName() {

}

function updatePhone() {

}

function updateMail() {

}

function updateLogin() {

}

function updatePassword() {

}

function updateLocation() {

}

function updateImageProfile() {

}


window.onload = function () {
    LoadInfoUserProfileAtTheContent();
}


function LoadInfoUserProfileAtTheContent() {
    $.ajax({
        url: 'UserProfile/LoadUserInfo',
        type: "POST",
        processData: false,
        contentType: false,
        success: function (response) {
            if(response != null){
                $("#infoP_surname").val(response.Surname);
                $("#infoP_name").val(response.Name);
                $("#infoP_lastname").val(response.LastName);
                $("#infoP_phone").val(response.Phone);
                $("#infoP_mail").val(response.Mail);
                $("#infoP_login").val(response.Login);
                $("#infoP_password").val(response.Password);
            }
            else {
                alert("Ошыбка обратитесь к администратору сайта")
            }
        }
    });
}


function updateNameUser() {

}

function updateSurname() {

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


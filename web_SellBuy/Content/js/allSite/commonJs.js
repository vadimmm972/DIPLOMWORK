imageName = "";



window.onload = function () {
    loadInfoUser();
}



function loadInfoUser() {
    $.ajax({
        url: 'Authentication/LoadUserInfo',
        type: "POST",
        processData: false,
        contentType: false,
        success: function (response) {
            if(response != null){
                $(".nameBlockInfoUser").text(response.userName);
                $(".SurnameLastNameInfo").text(response.userSurname + " " + response.userName);
                $(".SurnameLastNameInfo").text(response.userSurname + " " + response.userName);
                $(".emailProfileInfo").text(response.userMail);
                if (response.userPhotoProfile == null) {
                    $(".userPhoto").addClass("glyphicon-user");
                }
                else {
                    var imgProfile = "<img class=\"imgProfileStyle\" src=\"" + response.userPhotoProfile + "\"/>";
                    $(".userPhoto").append(imgProfile);
                }
            }
        }
    });
}


function loading(change) {
    if (change == 1) {
        $(".loadingBlock").css("display", "block");
    }
    else if (change == 0) {
        $(".loadingBlock").css("display", "none");
    }
}

function UploadImage(option) {
    var op = option;
    loading(1);
    var data = new FormData();
    var files = $(".uploadImage").get(0).files;
    if (files.length > 0) {
        data.append("HelpSectionImages", files[0]);

    }
    else {
        alert("error");
        return;
    }
    data.append("id", 11);
    data.append("elementid", 11);
    data.append("operation", op);
    $.ajax({
        url: 'Base/UploadImage',
        type: "POST",
        processData: false,
        contentType: false,
        data: data,
        success: function (response) {
            imageName = response;
            loading(0);
        }
    });
}



function SinIn_SIgnOut_RegisterUser_click(param) {
    if (param == 1) {
        window.location.href = "SignIn";
    }
    else if (param == 2) {
        window.location.href = "Authorization";
    }
    else if (param == 3) {
        $.ajax({
            url: 'Authentication/SignOut',
            type: "POST",
            processData: false,
            contentType: false,
            success: function (response) {
                    window.location.reload();
            }
        });
    }
}


function goUserProfilePage() {
    window.location.href = "UserProfile";
}
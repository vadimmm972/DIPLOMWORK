UrlImageProfile = "";

function registrationUser() {

    var surname = "";
    var name = "";
    var lastname = "";
    var phone = "";
    var email = "";
    var login = "";
    var password = $("#password").val();
    var confirmPass = $("#confirmPassword").val();
    var idCountry = "";
    var idrefion = "";
    var idSity = "";
   
    if (password !== confirmPass) {
        alert("Different passwords");
    }
    else {
        UploadImage("2");
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


function UploadImage(option) {
    var op;
    if (option == "magImg") {
        op = "1";
    }
    if (option == "usimg") {
        op = "2";
    }

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
        url: 'Authorization/UploadImage',
        type: "POST",
        processData: false,
        contentType: false,
        data: data,
        success: function (response) {
            // $("body").append("<img src=\"" + response + "\" >");
            if (op == "1") {
                $("#imgSaveMag").val(response);
            }
            if (op == "2") {
                $("#imgSave").val(response);
            }

        }
    });
}
$(document).ready(function () {
    $("#dialog").hide(); //скрываем окно при загрузке страница
});

function opendialog(val) {
    updateInfoDialogForm(val);
    $("#dialog").fadeIn(); //плавное появление блока
}

function closedialog() {
    $("#dialog").fadeOut(); //плавное исчезание блока
}


function updateInfoDialogForm(text) {
    $(".textInfoDialogForm").text(text);
}
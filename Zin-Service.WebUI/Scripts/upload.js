//$(document).ready(function () {
//    $('#btn-upload').change(function () {
//        $('#form-upload').submit();
//    });
//});

function UploadImageListener(urlAction) {
    $('#btn-upload').change(function () {
        var formData = new FormData($('#form-upload').get(0));
        UploadImage(urlAction, formData);
    });
}

function UploadImage(urlAction, uploadedFile) {
    $.ajax({
        url: urlAction,
        type: 'POST',
        data: uploadedFile,
        processData: false,
        contentType: false,
        success: function(response) {
            $('#uploaded-image').html('<img src="/' + response + '" class="img-responsive thumbnail" />');
        },
        error: function() {
            alert('Wystąpił problem przy wysyłaniu pliku na serwer.');
        }
    });
}
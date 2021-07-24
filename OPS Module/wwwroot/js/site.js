// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$("#PinCode").blur(function () {
    var pincode = $("#PinCode").val();
    var urlq = window.location.origin + "/state";
    $.ajax({
        type: "GET",
        url: "/state",
        contentType: "application/json; charset=utf-8",
        dataType: "text",
        data: { pincode: pincode },
        success: function (data) {
            var resdata = JSON.stringify(data);
            console.log(resdata);
        },
        failure: function (data) {
            alert(data.responseText);
        }, //End of AJAX failure function  
        error: function (data) {
            alert(data.responseText);
        }

    });
});
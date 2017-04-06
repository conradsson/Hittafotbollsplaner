function snackbarFunc() {
    var x = document.getElementById("snackbar")
    x.className = "show";
    setTimeout(function(){ x.className = x.className.replace("show", ""); }, 3000);
}

(function () {
    $('.form-group > input').keyup(function () {

        var empty = false;
        $('.form-group > input').each(function () {
            if ($(this).val() == '') {
                empty = true;
            }
        });

        if (empty) {
            $('#läggtillFP').attr('disabled', 'disabled');
        } else {
            $('#läggtillFP').removeAttr('disabled');
        }
    });
})
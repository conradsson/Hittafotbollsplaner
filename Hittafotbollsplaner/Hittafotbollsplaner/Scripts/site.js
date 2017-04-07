jQuery(window).load(function () {
    jQuery('.modal').modal('show').on('hide.bs.modal', function (e) {
        e.preventDefault();
    });
    jQuery('.modal').modal('hide')
});
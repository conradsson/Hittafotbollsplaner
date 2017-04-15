jQuery(window).load(function () {
    jQuery('.modal').modal('show').on('hide.bs.modal', function (e) {
        e.preventDefault();
    });
    jQuery('.modal').modal('hide')
});

//$('#return-to-top').click(function () {
//    $('body,html').animate({
//        scrollTop: 0
//    }, 300);
//});

$("#hideNav").click(function () {
    $(".navbar").toggle();
});

var scrollTo = function (identifier, speed) {  // Scroll-To function
    $('html, body').animate({
        scrollTop: $(identifier).offset().top
    }, speed || 750);
}



// HÄMTAR AKTUELL FOTBOLLSPLAN
//function aktuellFotbollsplan(elem) {

//    var id = $(elem).data('assigned-id');

//    //window.open('/Fotbollsplan/Index');

//    if (id != "") {

//        $.ajax({
//            url: '/Fotbollsplan/AktuellFotbollsplan',
//            contentType: 'application/html; charset=utf-8',
//            data: { id },
//            type: 'GET',
//            dataType: 'html',
//            success: function (result) {
//                $('body').html(result);
//            }
//        })
//    }
//}


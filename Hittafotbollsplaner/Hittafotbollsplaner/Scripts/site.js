$(document).ready(function () {

    if (window.location.pathname == '/Home/Index' || window.location.pathname == '/') {
        $('div.followStart').hide();
    }

    if (window.location.pathname == '/fotbollsplaners/Create') {
        if ($('#genInfoSlideIco').hasClass('glyphicon-chevron-down')) {
            $('#genInfoSlideIco').removeClass('glyphicon-chevron-down');
            $('#genInfoSlideIco').addClass('glyphicon-chevron-up');
            $("#G-toggle").slideDown("slow");
        }
        $("#P-toggle").slideUp("0");
        $("#T-toggle").slideUp("0");



        $(".genInfoSlide").click(function () {
            if ($('#genInfoSlideIco').hasClass('glyphicon-chevron-down')) {
                $('#genInfoSlideIco').removeClass('glyphicon-chevron-down');
                $('#genInfoSlideIco').addClass('glyphicon-chevron-up');
                $("#G-toggle").slideToggle("slow");
            }
            else if ($('#genInfoSlideIco').hasClass('glyphicon-chevron-up')) {
                $('#genInfoSlideIco').removeClass('glyphicon-chevron-up');
                $('#genInfoSlideIco').addClass('glyphicon-chevron-down');
                $("#G-toggle").slideToggle("slow");
            }
        });

        $(".planInfoSlide").click(function () {
            if ($('#planInfoSlideIco').hasClass('glyphicon-chevron-down')) {
                $('#planInfoSlideIco').removeClass('glyphicon-chevron-down');
                $('#planInfoSlideIco').addClass('glyphicon-chevron-up');
                $("#P-toggle").slideToggle("slow");
            }
            else if ($('#planInfoSlideIco').hasClass('glyphicon-chevron-up')) {
                $('#planInfoSlideIco').removeClass('glyphicon-chevron-up');
                $('#planInfoSlideIco').addClass('glyphicon-chevron-down');
                $("#P-toggle").slideToggle("slow");
            }
        });

        $(".tillgängligtSlide").click(function () {
            if ($('#tillgängligtSlideIco').hasClass('glyphicon-chevron-down')) {
                $('#tillgängligtSlideIco').removeClass('glyphicon-chevron-down');
                $('#tillgängligtSlideIco').addClass('glyphicon-chevron-up');
                $("#T-toggle").slideToggle("slow");
            }
            else if ($('#tillgängligtSlideIco').hasClass('glyphicon-chevron-up')) {
                $('#tillgängligtSlideIco').removeClass('glyphicon-chevron-up');
                $('#tillgängligtSlideIco').addClass('glyphicon-chevron-down');
                $("#T-toggle").slideToggle("slow");
            }
        });


        $("#läggtillFP").click(function () {
            $("#G-toggle").slideDown("slow");
            $("#P-toggle").slideDown("slow");
            $("#T-toggle").slideDown("slow");;
        });

        }

    $("#hideNav").click(function () {
        $(".navbar").toggle();
    });

    $('.rapporteralink').on('click', function (e) {
        e.preventDefault();

        $.ajax({
            type: "GET",
            url: '/Fotbollsplan/_Rapportera',
            success: function (result) {
                $('.information-panel').html(result);
            }
        });
    });

    var scrollTo = function (identifier, speed) {  // Scroll-To function
        $('html, body').animate({
            scrollTop: $(identifier).offset().top
        }, speed || 750);
    }
});
//jQuery(window).load(function () {
//    jQuery('.modal').modal('show').on('hide.bs.modal', function (e) {
//        e.preventDefault();
//    });
//    jQuery('.modal').modal('hide')
//});

//$('#return-to-top').click(function () {
//    $('body,html').animate({
//        scrollTop: 0
//    }, 300);
//});







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

// BETYGSÄTTNING
// Starrr plugin (https://github.com/dobtco/starrr)

﻿$(document).ready(function () {

    

    if (window.location.pathname == '../' || window.location.pathname == '/') {
        $('div.followStart').hide();
    }

    if (window.location.pathname == '/laggtillfotbollsplan') {
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

    var scrollTo = function (identifier, speed) {  // Scroll-To function
        $('html, body').animate({
            scrollTop: $(identifier).offset().top
        }, speed || 750);
    }
});

//$('#return-to-top').click(function () {
//    $('body,html').animate({
//        scrollTop: 0
//    }, 300);
//});



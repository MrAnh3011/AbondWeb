$(document).ready(function () {
    let height = $(window).height();
    let width = $(window).width();

    let search_width = width * 100 / 100;

    $('#header_login .search_mb form').css('min-width', search_width);

    // $('#slider img').css('height', height);

    $('.btn-toggle').click(function () {
        $('.menu_mb').toggleClass('menu_mb_show');
    })

    $('#slide').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        arrows: true,
        dots: false,
        fade: false,
        infinite: true,
        autoplay: true,
        draggable: true,
        cssEase: 'linear',
        prevArrow: '<button id="slick-prev" class="slick-prev slick-arrow" aria-label="Previous" type="button"><i class="fa fa-chevron-left"></i></button>',
        nextArrow: '<button id="slick-next" class="slick-next slick-arrow" aria-label="Next" type="button"><i class="fa fa-chevron-right"></i></button>',
        responsive: [{
            breakpoint: 320,
            settings: {
                fade: false,
                arrows: false,
                dots: true,
                autoplay: true,
                infinite: true,
                slidesToShow: 1,
                slidesToScroll: 1,
            }
        }]
    });

    $('#partner_slide').slick({
        slidesToShow: 5,
        slidesToScroll: 1,
        arrows: false,
        dots: false,
        fade: false,
        infinite: true,
        autoplay: true,
        draggable: true,
        cssEase: 'linear',
        responsive: [{
            breakpoint: 320,
            settings: {
                arrows: false,
                dots: false,
                autoplay: true,
                infinite: true,
                slidesToShow: 1,
                slidesToScroll: 1,
            }
        }]
    });

    $('#comment_slide').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        arrows: false,
        dots: true,
        fade: false,
        infinite: true,
        autoplay: true,
        draggable: true,
        cssEase: 'linear',
        responsive: [{
            breakpoint: 320,
            settings: {
                arrows: false,
                dots: false,
                autoplay: true,
                infinite: true,
                slidesToShow: 1,
                slidesToScroll: 1,
            }
        }]
    });

    $('.activity').slick({
        slidesToShow: 3,
        slidesToScroll: 1,
        arrows: true,
        dots: false,
        fade: false,
        infinite: true,
        autoplay: true,
        prevArrow: '<button id="slick-prev" class="slick-prev slick-arrow" aria-label="Previous" type="button"><i class="fa fa-chevron-left"></i></button>',
        nextArrow: '<button id="slick-next" class="slick-next slick-arrow" aria-label="Next" type="button"><i class="fa fa-chevron-right"></i></button>',
        draggable: true,
        cssEase: 'linear',
        responsive: [{
            breakpoint: 320,
            settings: {
                arrows: false,
                dots: false,
                autoplay: true,
                infinite: true,
                slidesToShow: 1,
                slidesToScroll: 1,
            }
        }]
    });

    $('.news_slide').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        arrows: true,
        dots: false,
        fade: false,
        infinite: true,
        autoplay: true,
        prevArrow: '<button id="slick-prev" class="slick-prev slick-arrow" aria-label="Previous" type="button"><i class="fa fa-chevron-left"></i></button>',
        nextArrow: '<button id="slick-next" class="slick-next slick-arrow" aria-label="Next" type="button"><i class="fa fa-chevron-right"></i></button>',
        draggable: true,
        cssEase: 'linear',
        responsive: [{
            breakpoint: 320,
            settings: {
                arrows: false,
                dots: false,
                autoplay: true,
                infinite: true,
                slidesToShow: 1,
                slidesToScroll: 1,
            }
        }]
    });

    $("#respMenu").aceResponsiveMenu({
        resizeWidth: '768', // Set the same in Media query       
        animationSpeed: 'fast', //slow, medium, fast
        accoridonExpAll: false //Expands all the accordion menu on click
    });

    $('#search_icon').click(function () {
        $(this).next().toggleClass('search_show');
    })




    // $('.page_content .abc').each(function (index, value) {
    // 	let this_height = $(this).height();
    // 	var top_height = this_height * 80 / 100;
    // 	$(this).find('img').first().css('height', top_height);

    // 	console.log(this_height + '_' + index);

    // });




    /*---------------------------------------------- AnhPT JS ---------------------------------------------*/


    //Set time on top barner
    function setRealTime() {
        const DayName = ["Chủ nhật", "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7"];
        let topHour = new Date().getHours();
        let topMinutes = new Date().getMinutes();
        let topDay = DayName[new Date().getDay()];
        let topDate = new Date().getDate() + "/" + (new Date().getMonth() + 1) + "/" + new Date().getFullYear();
        let topTimeStr = topHour + ":" + topMinutes + " - " + topDay + ", " + topDate;

        $('#datetime-barner').text(topTimeStr);
    };
    setRealTime();
    setInterval(setRealTime, 60 * 1000);

    var userLogin = getToken();
    if (userLogin) {
        $(".headerLog").css({ "display": "none" });
        let result = JSON.parse(userLogin);
        $(".userLogin").css({ "display": "block" });
        $("#userName").text(result.Username);
    }

    $("#logOut").click(function () {
        swal({
            title: "Bạn chắc chắn muốn thoát ?",
            icon: "warning",
            buttons: true,
        }).then((isConfirm) => {
            if (isConfirm) {
                removeToken();
                location.reload();
                //$(".userLogin").css({ "display": "none" });
                //$(".headerLog").css({ "display": "block" });
            }
        });
    });

    $(".searchIcon").click(function () {
        if ($(".searchInputText").css("display") == "none") {
            $(".searchInputText").css({ "display": "block" });
        }
        else {
            $(".searchInputText").css({ "display": "none" });
        }
    });

    $("#btnSubmitSearch").click(function () {
        var inputText = $("#searchContent").val();
        window.location.href = "/tim-kiem/" + inputText;
    });
});
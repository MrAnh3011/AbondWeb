$(document).ready(function () {
    let height = $(window).height();
    let width = $(window).width();

    let search_width = width * 100 / 100;

    function ShowLoadingScreen() {
        $(".loading-screen").css({ "display": "block" });
    }

    function HideLoadingScreen() {
        $(".loading-screen").css({ "display": "none" });
    }

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

    $("#activity_reality").slick({
        slidesToShow: 5,
        slidesToScroll: 1,
        autoplay: true,
        autoplaySpeed: 2000,
        prevArrow: false,
        nextArrow: false,
        dots: false,
        infinite: true,
        cssEase: 'linear',
        draggable: true,
        variableWidth: true
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

    $("#searchContent").on('keypress', function (e) {
        if (e.which == 13) {
            let inputText = $("#searchContent").val();
            window.location.href = "/tim-kiem/" + inputText;
        }
    });

    $("#search_mbc").on('keypress', function (e) {
        if (e.which == 13) {
            let inputText = $("#search_mbc").val();
            window.location.href = "/tim-kiem/" + inputText;
        }
    });

    $("#submitTroubleshooting").click(function () {
        ShowLoadingScreen();
        let ToMail = $("#mailReceiver").text();
        let SubjectMail = "Người dùng Abond - Yêu cầu hỗ trợ/giải đáp thắc mắc";
        let BodyMail = "Họ tên: " + $("#name").val() + "\n";
        BodyMail += "Số điện thoại: " + $("#phone").val() + "\n";
        BodyMail += "Email: " + $("#email").val() + "\n";
        BodyMail += "Nội dung: " + $("#contentText").val();
        let info = JSON.stringify({
            To: ToMail,
            Subject: SubjectMail,
            Body: BodyMail
        });

        $.ajax({
            url: "/api/sendmail",
            data: info,
            dataType: "json",
            type: "POST",
            contentType: "application/json",
            success: function (response) {
                HideLoadingScreen();
                if (response.status == "success")
                    swal("Thành công", "Đã gửi thông tin thành công, chúng tôi sẽ liên hệ bạn trong thời gian sớm nhất", "success");
                else 
                    swal("Lỗi", "Gửi thông tin không thành công, vui lòng kiểm tra lại thông tin", "error");
            },
            error: function (response) {
                HideLoadingScreen();
                swal("Lỗi", "Gửi thông tin không thành công, vui lòng kiểm tra lại thông tin", "error");
            }
        });
    });

    $("#getInfoBonds").click(function () {
        ShowLoadingScreen();
        let name = $("#name").val();
        let phone = $("#phone").val();
        let email = $("#email").val();
        let content = $("#message").val();

        let ToMail = $("#mailReceiver").text();
        let SubjectMail = "Người dùng Abond - Nhận thông tin về trái phiếu";

        if (!name || !phone) {
            swal("Lỗi", "Họ tên và số điện thoại là bắt buộc.", "error");
            HideLoadingScreen();
            return;
        }
        let mail_regex = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
        if (mail_regex.test(email) == false) {
            swal("Lỗi", "Email bạn vừa nhập không hợp lệ", "error");
            HideLoadingScreen();
            return;
        }
        let vnf_regex = /((09|03|07|08|05)+([0-9]{8})\b)/g;
        if (vnf_regex.test(phone) == false) {
            swal("Lỗi", "Số điện thoại bạn vừa nhập không hợp lệ.", "error");
            HideLoadingScreen();
            return;
        }


        let BodyMail = "Họ tên: " + name + "\n";
        BodyMail += "Số điện thoại: " + phone + "\n";
        BodyMail += "Email: " + email + "\n";
        BodyMail += "Nội dung: " + content;

        let info = JSON.stringify({
            To: ToMail,
            Subject: SubjectMail,
            Body: BodyMail
        });

        $.ajax({
            url: "/api/sendmail",
            data: info,
            dataType: "json",
            type: "POST",
            contentType: "application/json",
            success: function (response) {
                HideLoadingScreen();
                if (response.status == "success")
                    swal("Thành công", "Đã gửi thông tin thành công, bạn sẽ được nhận thông tin mới nhất về những sản phẩm của chúng tôi", "success");
                else
                    swal("Lỗi", "Gửi thông tin không thành công, vui lòng kiểm tra lại thông tin", "error");
            },
            error: function (response) {
                HideLoadingScreen();
                swal("Lỗi", "Gửi thông tin không thành công, vui lòng kiểm tra lại thông tin", "error");
            }
        });
    });

    $("#regBuyBonds").click(function () {
        debugger;
        ShowLoadingScreen();
        let name = $("#nameBonds").val();
        let phone = $("#phoneBonds").val();
        let email = $("#emailBonds").val();
        let content = $("#messageBonds").val();

        let ToMail = $("#mailReceiver").text();
        let SubjectMail = "Người dùng Abond - Nhận thông tin về trái phiếu";

        if (!name || !phone) {
            swal("Lỗi", "Họ tên và số điện thoại là bắt buộc.", "error");
            HideLoadingScreen();
            return;
        }
        let mail_regex = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
        if (mail_regex.test(email) == false) {
            swal("Lỗi", "Email bạn vừa nhập không hợp lệ", "error");
            HideLoadingScreen();
            return;
        }
        let vnf_regex = /^(0|\+84)(\s|\.)?((3[2-9])|(5[689])|(7[06-9])|(8[1-689])|(9[0-46-9]))(\d)(\s|\.)?(\d{3})(\s|\.)?(\d{3})$/;
        if (vnf_regex.test(phone) == false) {
            swal("Lỗi", "Số điện thoại bạn vừa nhập không hợp lệ.", "error");
            HideLoadingScreen();
            return;
        }


        let BodyMail = "Họ tên: " + name + "\n";
        BodyMail += "Số điện thoại: " + phone + "\n";
        BodyMail += "Email: " + email + "\n";
        BodyMail += "Nội dung: " + content;

        let info = JSON.stringify({
            To: ToMail,
            Subject: SubjectMail,
            Body: BodyMail
        });

        $.ajax({
            url: "/api/sendmail",
            data: info,
            dataType: "json",
            type: "POST",
            contentType: "application/json",
            success: function (response) {
                HideLoadingScreen();
                if (response.status == "success")
                    swal("Thành công", "Đã gửi thông tin thành công, bạn sẽ được nhận thông tin mới nhất về những sản phẩm của chúng tôi", "success");
                else
                    swal("Lỗi", "Gửi thông tin không thành công, vui lòng kiểm tra lại thông tin", "error");
            },
            error: function (response) {
                HideLoadingScreen();
                swal("Lỗi", "Gửi thông tin không thành công, vui lòng kiểm tra lại thông tin", "error");
            }
        });
    });

    $("#btnRegBuyNow").click(function () {
        $("#register_buynow .register").css({ "transform": "translateX(0px)" });
    });

    $("#closeformRegister").click(function () {
        $("#register_buynow .register").css({ "transform": "translateX(300px)" });
    });
});
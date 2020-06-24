$(function () {
    const BASE_URL = "http://api.mandalainn.vn";

    function ShowLoadingScreen() {
        $(".loading-screen").css({ "display": "block" });
    }

    function HideLoadingScreen() {
        $(".loading-screen").css({ "display": "none" });
    }

    var countDown;
    function SetIntervalModal(item, time) {
        ClearIntervalModal(item);
        countDown = setInterval(function () {
            item.text(time);
            time -= 1;
        }, 1000);
    }

    function ClearIntervalModal(item) {
        clearInterval(countDown);
        item.text(180);
    }

    $("#btnregister").click(function () {
        window.location.href = "/register";
    });
    $("#forgotPass").click(function () {
        window.location.href = "/register";
    });

    $("#btnlogin").click(function () {
        try {
            let logInUserName = $("#username").val();
            let logInPassWord = $("#password").val();
            if (logInUserName === "" || logInPassWord === "") {
                swal("Lỗi !", "Bạn cần nhập đủ thông tin.", "error");
                return;
            }
            ShowLoadingScreen();
            let path = "/session/login";
            $.ajax({
                url: (BASE_URL + path),
                data: JSON.stringify({
                    username: logInUserName,
                    password: logInPassWord
                }),
                dataType: "json",
                type: "POST",
                contentType: "application/json",
                success: function (response) {
                    if (response.status == "Ok") {
                        let result = response.result;
                        let loginModel = {
                            SessionKey: result.SessionKey,
                            SessionID: result.SessionID,
                            UserID: result.UserID,
                            Username: result.Username,
                            BranchId: result.BranchId,
                            DisplayName: result.DisplayName,
                            SessionStatus: result.SessionStatus,
                            AllowDevelop: result.AllowDevelop,
                            AllowViewAllData: result.AllowViewAllData
                        };
                        HideLoadingScreen();
                        saveToken(JSON.stringify(loginModel));
                        window.location.href = "/";
                    } else {
                        HideLoadingScreen();
                        swal("Lỗi !", "Tên đăng nhập hoặc mật khẩu không đúng", "error");
                        return;
                    }
                },
                error: function (response) {
                    HideLoadingScreen();
                    swal("Lỗi !", response, "error");
                }
            });

        } catch (e) {
            swal("Lỗi !", e, "error");
        }
    });

    $("#btnOTP").click(function () {
        let phoneNum = $("#username").val();
        if (!phoneNum) {
            swal("Lỗi", "Bạn phải nhập đầy đủ số điện thoại", "error");
            return;
        }
        try {
            let path = "/api/auth/sendotp";
            $.ajax({
                url: (BASE_URL + path),
                data: JSON.stringify({
                    UserName: phoneNum
                }),
                dataType: "json",
                type: "POST",
                contentType: "application/json",
                success: function (response) {
                    if (response.status == "Ok") {
                        console.log(response);
                        swal("Thành công", "Vui lòng chờ tin nhắn và nhập mã OTP gồm 6 chữ số vào ô ", "success");
                        $(".otpCount").css({ "display": "block" });
                        SetIntervalModal($("#countDown"), 179);
                    } else {
                        swal("Lỗi !", "Số điện thoại vừa nhập không đúng", "error");
                    }
                },
                error: function (response) {
                    swal("Lỗi !", response, "error");
                },
            });
        } catch (e) {
            swal("Lỗi !", e, "error");
        }
    });

    $("#submitRegBtn").click(function () {
        let phoneNum = $("#username").val();
        let pass = $("#password").val();
        let repass = $("#rePassword").val();
        let otp = $("#inputOTP").val()

        if (!phoneNum || !pass || !repass || !otp) {
            swal("Lỗi", "Bạn phải nhập đầy đủ thông tin", "error");
            return;
        }

        let pathOTP = "/api/auth/vertifyotp";
        try {
            $.ajax({
                url: (BASE_URL + pathOTP),
                data: JSON.stringify({
                    UserName: phoneNum,
                    OTPCode: otp
                }),
                dataType: "json",
                type: "POST",
                contentType: "application/json",
                success: function (response) {
                    if (response.status == "Ok") {
                        let pathReg = "/api/auth/register";
                        try {
                            $.ajax({
                                url: (BASE_URL + pathReg),
                                data: JSON.stringify({
                                    UserName: phoneNum,
                                    Password: pass,
                                    VertifiedPassword: repass,
                                }),
                                dataType: "json",
                                type: "POST",
                                contentType: "application/json",
                                success: function (data) {
                                    if (data.status == 'Ok') {
                                        swal({
                                            title: "Thành công",
                                            text: "Tài khoản tạo thành công",
                                            icon: "success",
                                            button: "Đăng nhập"
                                        }).then((isConfirm) => {
                                            if (isConfirm)
                                                window.location.href = "/login";
                                        });
                                    } else {
                                        swal("Lỗi", data.reason, "error");
                                    }
                                },
                                error: function (data) {
                                    swal("Lỗi", data.reason, "error");
                                },
                            });
                        } catch (e) {
                            swal("Lỗi !", e, "error");
                        }
                    }
                    else {
                        swal("Lỗi", response.reason, "error");
                    }
                },
                error: function (response) {
                    swal("Lỗi", response.reason, "error");
                },
            });
        } catch (e) {
            swal("Lỗi !", e, "error");
        }
    });
});
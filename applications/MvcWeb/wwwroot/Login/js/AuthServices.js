function saveToken(tokenKey) {
    let date = new Date();
    let hour = 5;
    date.setTime(date.getTime() + (hour * 60 * 60 * 1000));
    $.cookie("SessionUser", tokenKey, { expires: date });
};
function getToken() {
    return $.cookie("SessionUser");
}
function removeToken() {
    $.removeCookie("SessionUser");
}
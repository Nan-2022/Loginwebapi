

var GetLogin = function () {
    var UserName = $('#txtUserName').val();
    var Password = $('#txtPassword').val();
    var Loginurl = "/api/Values/GetLogin";
    var LoginData = JSON.stringify({ "UserName": UserName, "Password": Password });
        $.ajax({
        type: "POST",
        data: LoginData,
        url: Loginurl,
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            alert(result)
        },
        error: function (result) {
            alert(result)
        }
   });      

};
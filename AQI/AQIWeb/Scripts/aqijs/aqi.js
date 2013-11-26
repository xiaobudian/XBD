AQI = function ($) {
    this.GetAQIData = function () {
        $.ajax({
            url: 'http://www.pm25.in/api/querys/pm2_5.json?city=010',
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                alert(data);
            },
            error: function (data) {
                alert(data);
            }
        });
    };
    this.alertMsg = function (msg) {
        alert(msg);
    }
}

function MoveCardTo(event) {
    var e = event || window.event;
    $(".card").animate({ "left": e.x + "px", "top": e.y + "px" }, "slow", "swing");
}

function SendCard() {

    $(".person").each(function (index, obj) {

        var mydiv = $("<div>");
        var cardNumber = $("<p>");
        cardNumber.html(Math.round(Math.random() * 100));
        cardNumber.css("color", "white");
        mydiv.append(cardNumber);

        mydiv = mydiv.addClass("mycard");      
        var r = Math.round(Math.random() * 10);
        var g = Math.round(Math.random() * 10);
        var b = Math.round(Math.random() * 10);
        mydiv.css("background-color", "#" + r + g + b);
        mydiv.css("left", "510px");
        mydiv.css("top", "180px");
        mydiv.css("z-index", "4");
        $("#root").append(mydiv);
        mydiv.animate({ "left": $(obj).css("left"), "top": $(obj).css("top") }, "slow", "swing", function () {            
            mydiv.css("left","0px");
            mydiv.css("top","0px");
            $(obj).append(mydiv);           
        });
        
    });   
}

var timer = window.setInterval(function () {
    $(".person").each(function (index, obj) {

        $(obj).children(":last-child").remove();
    });
}, 1000);
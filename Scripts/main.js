$(document).ready(function () {
    $("section.loginForm").backstretch("../Images/background1.jpg");


    $('.icon-down-open').on('click', function () {
        $('section.loginForm .box.one').addClass('animated fadeOutUpBig');
        $('.overlay').css('opacity', '0');
        $('.loginInput').addClass('animated fadeInUpBig').show();
    });

    //OPENING TICKET BEGIN

    $('.ticket-item').on('click', function () {
        var item_topic = $(this).find('h3').text();

        $('.tickets-list').fadeOut(400);
        $('.item-ticket').slideDown(1000);

        $('.item-ticket .ticket-name').text(item_topic);
    });

    //OPENING TICKET END
});
$(document).ready(function () {
    $("#shortDemo").hide().fadeIn(1200);

    $.getJSON(uri)
        .done(function (data) {
            $.each(data, function (key, item) {
                $('<li>', { text: formatItem(item) }).appendTo($('#teams'));
            });
        });
});
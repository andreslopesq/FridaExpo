
$(document).ready(function () {

    (function ($) {

        $('#buscar').keyup(function () {

            var rex = new RegExp($(this).val(), 'i');
            $('.buscar1 div').hide()
            $('.buscar1 div').filter(function () {
                return rex.test($(this).text());
            }).show();

        })

    }(jQuery));

});



$.fn.makeLink = function (options) {
    var settings = $.extend({
        height: '800',
        width: '600',
        top: '100',
        left: '100',
        scrollbars: 'yes',
    }, options);

    this.filter('a').each(function (index) {
        var link = $(this);
        var href = link.attr('href');
        var name = link.attr('data-window-group');
        link.click(function () {
            window.open(href, name, 'height=' + options.height + 
                                    ',width=' + options.width + 
                                    ',top=' + options.top +
                                    ',left=' + options.left +
                                    ',scrollbars=' + options.scrollbars);
            return false;
        });
    });
    return this;
}
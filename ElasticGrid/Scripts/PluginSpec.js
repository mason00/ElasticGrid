/// <reference path="../Scripts/jasmine.js"/>
/// <reference path="./jquery-1.10.2.min.js" />
/// <reference path="./Plugin.js" />

describe("string startsWith", function () {
    it("test plugin", function () {
        $('body').append($("<a data-window-group='a' href='test.html'>test</a><br/>" +
          "<a data-window-group='a' href='test1.html'>test</a><br/>" +
          "<a data-window-group='b' href='test2.html'>test</a><br/>" +
          "<a data-window-group='b' href='test3.html'>test</a><br/>").makeLink({
              height: 500,
              width: 500,
              top: 100,
              left: 100,
              scrollbars: 'no'
          }));
    });
}); 
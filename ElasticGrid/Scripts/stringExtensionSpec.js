/// <reference path="../Scripts/jasmine.js"/>
/// <reference path="./stringExtension.js" />
/// <reference path="./jquery-1.10.2.min.js" />

describe("string startsWith", function () {
    it("test string", function () {
        expect('hang the dj'.startsWith('hang')).toBeTruthy();
    });

    it("test case sensitive", function () {
        expect('hang the dj'.startsWith('Hang')).toBeFalsy();
    });

    it("test fasle string", function () {
        expect('hang the dj'.startsWith('I\'ve got a room for rent')).toBeFalsy();
    });

    it("test empty string", function () {
        expect('hang the dj'.startsWith('')).toBeTruthy();
    });

    it("test blank space", function () {
        expect('hang the dj'.startsWith('hang the')).toBeTruthy();
    });

    it("test number", function () {
        expect('hang the dj'.startsWith(42)).toBeFalsy();
    });

    it("test object", function () {
        expect('hang the dj'.startsWith({ first: "Johnny" })).toBeFalsy();
    });
});

describe("string endsWith", function () {
    it("test string", function () {
        expect('hang the dj'.endsWith('dj')).toBeTruthy();
    });

    it("test false string", function () {
        expect('hang the dj'.endsWith('panic on the streets')).toBeFalsy();
    });

    it("test empty string", function () {
        expect('hang the dj'.endsWith('')).toBeTruthy();
    });

    it("test blank space", function () {
        expect('hang the dj'.endsWith('the dj')).toBeTruthy();
    });

    it("test number", function () {
        expect('hang the dj'.endsWith(42)).toBeFalsy();
    });

    it("test object", function () {
        expect('hang the dj'.endsWith({ first: "Johnny" })).toBeFalsy();
    });
});

describe("string stripHtml", function () {
    it("test strip", function () {
        expect('<p>Shoplifters of the World <em>Unite</em>!</p>'.stripHtml()).toBe('Shoplifters of the World Unite!');
    });

    it("test encoded tag", function () {
        expect('1 &lt; 2'.stripHtml()).toBe('1 &lt; 2');
    });
});
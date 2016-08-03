String.prototype.startsWith = function (str) {
    return this.slice(0, str.length) === str;
}

String.prototype.endsWith = function (str) {
    return this.indexOf(str, this.length - str.length) !== -1;
}

String.prototype.stripHtml = function () {
    var regex = /(<([^>]+)>)/ig
    return this.replace(regex, "");
}
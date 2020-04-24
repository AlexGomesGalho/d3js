var Wish = /** @class */ (function () {
    function Wish() {
    }
    Wish.prototype.greet = function () {
        console.log("Good Morning");
    };
    return Wish;
}());
var obj = new Wish();
obj.greet();

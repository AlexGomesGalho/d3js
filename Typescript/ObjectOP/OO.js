var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Editor;
(function (Editor) {
    Editor[Editor["marvel"] = 0] = "marvel";
    Editor[Editor["DC"] = 1] = "DC";
})(Editor || (Editor = {}));
//Best part of interface is that it can be implemented by a class and also an object 
var batman = {
    name: "Batman",
    CreationYear: 1986
};
var SuperHero = /** @class */ (function () {
    function SuperHero(name, editor, CreationYear) {
        this.name = name;
        this.editor = editor;
        this.CreationYear = CreationYear;
        this.name = name;
    }
    SuperHero.prototype.createMessage = function () {
        return "\n        Super Hero: \n        " + this.name + "\n        " + Editor[this.editor] + "\n        " + this.CreationYear;
    };
    return SuperHero;
}());
var Flyinghero = /** @class */ (function (_super) {
    __extends(Flyinghero, _super);
    function Flyinghero() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Flyinghero.prototype.fly = function (message) {
        console.log(message + this.CreationYear);
    };
    return Flyinghero;
}(SuperHero));
var Thor = new Flyinghero('Thor', Editor.marvel, 1984);
console.log(Thor.createMessage());
var IronMan = new SuperHero('Tony Stark', Editor.marvel, 1983);
console.log(IronMan);

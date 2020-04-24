function calculateDiscount(price, rate) {
    var discount = price * rate;
    console.log("Discount" + discount);
}
calculateDiscount(1000, 0.5);
//The Function Constructor 
var myFunction = new Function("a", "b", "return a * b");
var x = myFunction(4, 5);
console.log(x);
function createHelloMessage(name) {
    return "Hello, My name is " + name;
}
var creator = createHelloMessage;
var Name = creator("Aditya N");
console.log(Name);
function createHelloMessage1(name) {
    return "Hello, My name is " + name;
}
var creator1 = createHelloMessage;
var Name1 = creator("Aditya N Sharma");
console.log(Name1);

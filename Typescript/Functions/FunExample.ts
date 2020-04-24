function calculateDiscount(price:number,rate:number){
var discount=price*rate;
console.log("Discount"+discount)
}
calculateDiscount(1000,0.5)

//The Function Constructor 

var myFunction = new Function("a","b","return a * b");
var x = myFunction(4,5)
console.log(x)


//Function Type
type MessageCreator = (name:string) => string

function createHelloMessage(name : string){
    return `Hello, My name is ${name}`
}

const creator : MessageCreator = createHelloMessage;
const Name = creator("Aditya N")
console.log(Name)


//Function Type and Interface
interface MessageCreator1 {
    (name:string) :string
}

function createHelloMessage1(name : string){
    return `Hello, My name is ${name}`
}

const creator1 : MessageCreator = createHelloMessage;
const Name1 = creator("Aditya N Sharma")
console.log(Name1)
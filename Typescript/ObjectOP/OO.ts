enum Editor {
    marvel,
    DC
}

interface Hero{
    name:string;
    CreationYear : number;
}

//Best part of interface is that it can be implemented by a class and also an object 

const batman:Hero = {
    name :"Batman",
    CreationYear : 1986
}; 

class SuperHero implements Hero
{
    constructor (
        public name:string,
        public editor : Editor,
        public CreationYear : number
    ){this.name = name; }
    
    createMessage()
    {
        return `
        Super Hero: 
        ${this.name}
        ${Editor[this.editor]}
        ${this.CreationYear}`;
    }

}

interface CanFly{           //Interface example
    fly(message:string):void;   
}
class Flyinghero extends SuperHero implements CanFly {                           //Class Inheritance

    fly(message :string){
        console.log(message + this.CreationYear)
    }

}

const Thor = new Flyinghero('Thor',Editor.marvel,1984)
console.log(Thor.createMessage());


const IronMan  = new SuperHero ('Tony Stark',Editor.marvel,1983)

console.log(IronMan);
//When to use type vs Interfaces
//Intersection Type 

//use interface to the fine properties to which the object will refer to 
//use type keywords to define type Aliases that combines other types together 

interface HasName {
    FirstName :String
    LastName : String 
}

interface HasAddress {
    Address : string 
}

type Player = (HasName & HasAddress) | null 

const player :Player = {FirstName: 'Aditya',LastName: 'Sharma',Address:'Bangalore'}
console.log(player) 
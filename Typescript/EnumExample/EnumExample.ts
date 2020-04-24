//Printing Values from the array 
type player =[string,number]

let Plyone : player = ['Aditya',0];
let PlySecond : player = ['Chetan',1]
let PlyThird : player = ['Ashuthosh',2]

let players : player[] = [Plyone,PlySecond,PlyThird]
console.log(players)

//Printing using ENum

enum playerposition{
    guard,
    forward,
    center
}
type player1 =[string,playerposition]

let Plyone1 : player | null = ['Aditya',playerposition.guard]; //union Type 
let PlySecond1: player = ['Chetan',playerposition.forward]
let PlyThird1 : player = ['Ashuthosh',playerposition.center]

Plyone1 = null;
let players1 : player[] = [Plyone,PlySecond,PlyThird]
console.log(players1)   
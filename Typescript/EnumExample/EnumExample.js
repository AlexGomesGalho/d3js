var Plyone = ['Aditya', 0];
var PlySecond = ['Chetan', 1];
var PlyThird = ['Ashuthosh', 2];
var players = [Plyone, PlySecond, PlyThird];
console.log(players);
//Printing using ENum
var playerposition;
(function (playerposition) {
    playerposition[playerposition["guard"] = 0] = "guard";
    playerposition[playerposition["forward"] = 1] = "forward";
    playerposition[playerposition["center"] = 2] = "center";
})(playerposition || (playerposition = {}));
var Plyone1 = ['Aditya', playerposition.guard];
var PlySecond1 = ['Chetan', playerposition.forward];
var PlyThird1 = ['Ashuthosh', playerposition.center];
var players1 = [Plyone, PlySecond, PlyThird];
console.log(players1);

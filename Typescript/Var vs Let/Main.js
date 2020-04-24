function Sample() {
    for (var i = 0; i < 5; i++) {
        console.log(i);
    }
    console.log("Var key works till nearest function" + i);
    console.log("let key word works only for that particular function ");
}
Sample();

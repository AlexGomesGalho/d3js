function builtPersondetail(_a) {
    var FirstName = _a.FirstName, SecondName = _a.SecondName, Age = _a.Age;
    return FirstName + " " + SecondName + " " + Age;
}
var PersonData = {
    FirstName: 'Aditya',
    SecondName: 'Sharma',
    Age: '21'
};
builtPersondetail(PersonData);

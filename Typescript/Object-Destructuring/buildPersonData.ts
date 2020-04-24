function builtPersondetail({FirstName,SecondName,Age}){
    return `${FirstName} ${SecondName} ${Age}`;
}

const  FirstName= 'Aditya',
        SecondName='Sharma',
        Age='21';

const PersonData = {
  FirstName,
  SecondName,
  Age
};

builtPersondetail(PersonData)
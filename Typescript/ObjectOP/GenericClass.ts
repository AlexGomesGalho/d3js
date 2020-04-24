class SuperCharacter{
    constructor(public name:string){

    }
}

class hero extends SuperCharacter{

}

class villan extends SuperCharacter{

}

class SuperTeam<T> {
    constructor(public members : T[], public leader : T ){

    }
}

const CaptainAmerica = new hero("Captain America");
const Bucky = new hero("Bucky");
const BlackPanther= new hero("BlackPanther");


const Avengers = new SuperTeam ([CaptainAmerica,Bucky,BlackPanther],CaptainAmerica);

const members =Avengers.members
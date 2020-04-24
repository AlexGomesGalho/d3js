import express from 'express';

//instance of express 
const app = express();

//Get API

app.get("/", (req,res) => {

    const output  = {data: 'Hello Aditya. This is get method'};
    res.json(output);
});

//Post API

app.post("/", (req,res) => {

    const output  = {data: 'Hello Aditya.This is post method'};
    res.json(output);
});

//Put API

app.put("/", (req,res) => {

    const output  = {data: 'Hello Aditya.This is put method'};
    res.json(output);
});

//Delete API

app.delete("/", (req,res) => {

    const output  = {data: 'Hello Aditya.This is Delete method'};
    res.json(output);
});



app.listen(8090,() =>{
    console.log('Server is now running on port 8090 !!');
})
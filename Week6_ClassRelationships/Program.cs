using Week6_ClassRelationships.Composition;

Vehicle myVehicle = new Vehicle("1", "Toyota", "Mark1");
Engine myEngine = new Engine() { EngineNumber= "2",
    Make ="Peugeot", Model= "1.6 diesel" };

myVehicle.Engine = myEngine;


myVehicle = null;
//myEngine will myEngine stop to exist? Answer-> no hence not composition!


Company c = new Company();
c.Name = "MCAST";

c.AddDepartment("Information Communications Technology", "ICT");
c.AddDepartment("Institute of Applied Sciences", "IAS");


c = null;
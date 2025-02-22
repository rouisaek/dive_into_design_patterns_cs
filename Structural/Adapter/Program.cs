using Adapter;


var ocean = new Ocean(new Boat("Storm Razor 621"));
Console.WriteLine(ocean.GetOceanTransportName());

var sky = new Sky(new Plane("Skydiver 462"));
Console.WriteLine(sky.GetSkyTransportName());

var seaplane = new PlaneAdapter(new Boat("Sky Shark Hunter X13"));
Console.WriteLine(seaplane.GetName());

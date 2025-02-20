using Adapter;


Ocean ocean = new Ocean(new Boat("Stormrazor 621"));
Console.WriteLine(ocean.GetOceanTransportName());

Sky sky = new Sky(new Plane("Skydiver 462"));
Console.WriteLine(sky.GetSkyTransportName());

PlaneAdapter seaplane = new PlaneAdapter(new Boat("Sky Shark Hunter X13"));
Console.WriteLine(seaplane.GetName());

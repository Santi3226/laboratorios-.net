using Clases;
using System;
int radio = Convert.ToInt32(Console.ReadLine());
Circulo circulo = new Circulo();
circulo.Radio = radio;
circulo.GetPer();
circulo.GetArea();
Persona persona = new Persona();
persona.Nombre = "Juan";
persona.Apellido = "Pérez";
persona.GetName();
List<Persona> personas = new List<Persona>();
personas.Add(persona);
personas.Add(new Persona("Ana", "Gómez", 12345678));

foreach(Persona p in personas)
{
    p.GetName();
}


var personas2 = from p in personas where p.Nombre == "Juan" select p; 
foreach(Persona p in personas2)
{
    p.GetName();
}
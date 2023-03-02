
using LABORATORIO1_AlvinNoeAlvaradoMartinez.Entidades;
using LABORATORIO1_AlvinNoeAlvaradoMartinez.Negocio;
using System;

Persona persona = new Persona();
ClsPersona clspersona = new ClsPersona();



Console.WriteLine("Ingresa tu Nombre: ");
persona.Nombre = Console.ReadLine();

Console.WriteLine("Ingresa tu edad: ");
persona.Edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Dime tu sexo(H o M): ");
persona.Sexo = Console.ReadLine();

Console.WriteLine("Ingresa tu peso(Kg): ");
persona.Peso = float.Parse (Console.ReadLine());

Console.WriteLine("Ingresa tu Altura: ");
persona.Altura = float.Parse (Console.ReadLine());




Console.WriteLine(clspersona.CalcularIMC(persona));
Console.WriteLine(clspersona.EsMayorDeEdad(persona));

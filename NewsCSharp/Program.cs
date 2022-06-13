// See https://aka.ms/new-console-template for more information
using NewsCSharp.Commons;
using NewsCSharp.Entities;

//ya no es necesario en C# 9 las llaves de cierre y el metodo principal top level programs
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("ola k ase");
//    }
//}

Console.WriteLine("Hello, World!");

//testiando inmutabilidad
var p = new Place
{
    Name = "Mordor",
    Founder = "Sauron"
};

//una vez ya asignado la propiedad init, ya no es posible asignar un nuevo valor a la propiedad
 // p.Founder = "ss";

Console.WriteLine($"p1 {p.Name} {p.Founder}");

//testiando Record
var p2 = new Place2("santos", "pool");
//una vez ya asignado la propiedad init, ya no es posible asignar un nuevo valor a la propiedad
//p2.Founder = "ss";
var p2Copy = p2 with { Founder = "Nahuat" };
var (name, founder) = p2;
var (nameCopy, founderCopy) = p2Copy;
Console.WriteLine($"p2 {name} {founder}");
Console.WriteLine($"p2copy {nameCopy} {founderCopy}");

//aplicando Herencia en clases tipo record
var p3 = new Place3() { Name = "Santitos"};
var p4 = new Place4("Santitos Inherit", "Nahuat inherit");
Console.WriteLine($"p3 {p3.Name}");
Console.WriteLine($"p4 {p4.Name} {p4.Founder}");



// nueva estructura de switch
var resp = PopulationCommon.SayPopulation(0);
Console.WriteLine($"switch value {resp}");

var resp2 = PopulationCommon.SayPopulationV2(new Place() { Population = 10 });
Console.WriteLine($"switch value v2 {resp2}");

//validacion de objetos
var resp3 = PopulationCommon.ValidateModel(new Place());
Console.WriteLine($"validte model response  {resp3}");

//instancia sin especificar tipo nuevamente con new
Place resp4 = new() { Population = 1000};
Console.WriteLine($"value instance in population propertie  {resp4.Population}");

// valor nulable con int
bool existData  = true;
int? result = existData ? 1 : null;
Console.WriteLine($"nullable value with int  {result.GetValueOrDefault(0)}");

// tipo base compartido
Student student = null ;
Customer customer = new() { Id =111, Credit =234234};
Person? person = student is null ? customer : null;
Console.WriteLine($"person value with shared base type {person?.Id}");

//covariant returns uso de contravarianza
var tiger = new Tiger().GetFood();
Console.WriteLine($"tiger food and size {tiger.FoodType} {tiger.MeatSize}");
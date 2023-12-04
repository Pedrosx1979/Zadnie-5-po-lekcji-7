// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Podaj  swój wiek: ");

int age = Int32.Parse(Console.ReadLine());

if (age >= 35)
{
    Console.WriteLine($"Jeeli masz {age} lat, możesz zostać Posłęm, Senatorem, Premierem lub Prezydentem");
}
else if (age >= 30)
{
    Console.WriteLine($"Jeeli masz {age} lat, możesz zostać Posłęm, Senatorem lub Prezydentem");
}
else if (age >= 21)
{
    Console.WriteLine($"Jeeli masz {age} lat, możesz zostać Posłęm,lub Prezydentem");
}
else
{
    Console.WriteLine($"Możesz zostać Posłęm, Senatorem, Premierem lub Prezydeniem");
};
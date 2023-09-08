using ÖvningsUppgifter;
using System.Diagnostics;
using System.Formats.Asn1;

int height;
int width;
int radius;
int val;
IShape ishape = null;

Console.WriteLine("Är det en Circle{1}, en Cylinder{2}, en Rektangel{3}, en Sfär{4} eller en Triangel{5}");

val = int.Parse(Console.ReadLine());

if (val == 1)
{
    Console.WriteLine("Ange radien:");

    radius = int.Parse(Console.ReadLine());

    ishape = new Circle(radius);
} else if (val == 2)
{
    Console.WriteLine("Ange radien:");

    radius = int.Parse(Console.ReadLine());

    Console.WriteLine("Ange höjd:");

    height = int.Parse(Console.ReadLine());

    ishape = new Cylinder(radius, height);
} else if (val == 3)
{
    Console.WriteLine("Ange bredd:");

    width = int.Parse(Console.ReadLine());

    Console.WriteLine("Ange höjd:");

    height = int.Parse(Console.ReadLine());

    ishape = new Rectangle(width, height);
} else if (val == 4)
{
    Console.WriteLine("Ange radien:");

    radius = int.Parse(Console.ReadLine());

    ishape = new Sphere(radius);
} else if (val == 5)
{
    Console.WriteLine("Ange bredd:");

    width = int.Parse(Console.ReadLine());

    Console.WriteLine("Ange höjd:");

    height = int.Parse(Console.ReadLine());

    ishape = new Triangle(width, height);
}


Console.WriteLine("Arean är: " + ishape.Area() +" Omkretsen är: " + ishape.Circumference());
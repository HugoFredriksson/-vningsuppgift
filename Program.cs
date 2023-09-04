using ÖvningsUppgifter;
using System.Diagnostics;
using System.Formats.Asn1;

int height;
int width;
int val;
Shape shape = null;
Console.WriteLine("Ange höjd:");

height = int.Parse(Console.ReadLine());

Console.WriteLine(("Ange bredd:"));

width = int.Parse(Console.ReadLine());

Console.WriteLine("Är det en rektangel(1) eller en triangel(2)");

val = int.Parse(Console.ReadLine());

if (val == 1)
{
    shape = new Rectangle(height, width);

} else if (val == 2) 
{
    shape = new Triangle(height, width);
}
Console.WriteLine("Arean är: "+ shape.Area());
Console.WriteLine("Omkretsen är: " + shape.Circumference());
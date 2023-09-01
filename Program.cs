using ÖvningsUppgifter;

int height;
int width;
int val;
int circ = 0;
int area = 0;

Console.WriteLine("Ange höjd:");

height = int.Parse(Console.ReadLine());

Console.WriteLine(("Ange bredd:"));

width = int.Parse(Console.ReadLine());

Console.WriteLine("Är det en rektangel(1) eller en triangel(2)");

val = int.Parse(Console.ReadLine());

if (val == 1)
{
    Rectangle b = new Rectangle(height, width);

    Console.WriteLine("Omkretsen är: " + b.rCirc() + " och arean är: " + b.rArea());
} else if (val == 2) 
{
    Triangle a = new Triangle(height, width);

    Console.WriteLine("Omkretsen är "+ a.Circ() +" och arean är "+ a.Area());
}
using Adapter;
using Adapter.Adapter;
using Adapter.Shapes;

IShape rect = new Rectangle(4);
IShape triangle = new Triangle(3, 4, 5, 2.4f);
IShape ellipse = new EllipseAdapter(new Ellipse(12, 9));

Console.WriteLine(rect.Square());
Console.WriteLine(triangle.Square());
Console.WriteLine(ellipse.Square());

rect.Draw();
triangle.Draw();
ellipse.Draw();

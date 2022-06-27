using System;
using System.Collections.Generic;
using System.Threading;

double x0, y0;
var vectors = new List<(double x, double y)>();
int n;
Console.WriteLine("Enter number of vectors");
n = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
for (int i = 0; i < n; i++)
{
    x0 = rnd.Next(11);
    y0 = rnd.Next(11);
    vectors.Add((x0, y0));
}
Console.WriteLine("Vectors");
for(int i = 0; i < vectors.Count; i++)
{
    //Console.WriteLine(vectors[i].x);
    //Console.WriteLine(vectors[i].y);
    Console.WriteLine("Vector number {2} = {0} {1}", vectors[i].x, vectors[i].y, i);
}
Console.WriteLine("Combining vectors");
x0 = 0;
y0 = 0;
for (int i = 0; i < vectors.Count; i++)
{ x0 = x0 + vectors[i].x;
  y0 = y0 + vectors[i].y;
}
Console.WriteLine("Resulting Vector = {0} {1}", x0, y0);

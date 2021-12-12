using System;
using System.IO;

var depths = File.ReadAllLines("input.txt");
int increases = 0, previousDepth = int.MaxValue;

foreach (var depth in depths)
{
    if (Convert.ToInt32(depth) > previousDepth)
        increases++;
    previousDepth = Convert.ToInt32(depth);
}
Console.WriteLine($"Depth increased {increases} times!");
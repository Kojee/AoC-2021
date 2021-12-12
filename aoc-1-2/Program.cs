var depths = File.ReadAllLines("input.txt").Select(i => Convert.ToInt32(i));

int previousWindow = int.MaxValue, increases = 0;

for (int i = 0; i < depths.Count() - 2; i++)
{
    var curWindow = depths.ElementAt(i) + depths.ElementAt(i + 1) + depths.ElementAt(i + 2);
    if (curWindow > previousWindow)
        increases++;
    previousWindow = curWindow;
}
Console.WriteLine($"{increases}");
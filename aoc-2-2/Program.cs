int horizontalPosition = 0, depth = 0, aim = 0;
foreach (var line in File.ReadAllLines("input.txt"))
{
    var command = line.Split(' ');
    switch (command[0])
    {
        case "forward":
            horizontalPosition += int.Parse(command[1]);
            depth += int.Parse(command[1]) * aim;
            break;
        case "up":
            aim -= int.Parse(command[1]);
            break;
        case "down":
            aim += int.Parse(command[1]);
            break;
    }
}

Console.WriteLine($"Result is {depth * horizontalPosition}");
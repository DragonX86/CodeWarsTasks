static int CountSheeps(bool[]? sheeps)
{
    // return sheeps?.Count(x => x) ?? 0;
    if (sheeps == null)
        return 0;

    int count = 0;

    foreach (var item in sheeps)
    {
        if (item != true)
            continue;

        count++;
    }

    return count;
}

var sheeps = new bool[] { true, false, true };

Console.WriteLine(CountSheeps(sheeps));
static int СenturyFromYear(int year)
{
    return year % 100 > 0 ? year / 100 + 1 : year / 100;
}

Console.WriteLine($"18 = {СenturyFromYear(1705)}");
Console.WriteLine($"19 = {СenturyFromYear(1900)}");
Console.WriteLine($"17 = {СenturyFromYear(1601)}");
Console.WriteLine($"20 = {СenturyFromYear(2000)}");
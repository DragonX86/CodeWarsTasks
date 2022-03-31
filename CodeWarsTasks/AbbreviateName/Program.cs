static string AbbrevName(string name)
{
    var initials = name.Split().Select(x => char.ToUpper(x[0])).ToArray();
    return $"{initials[0]}.{initials[1]}";
}

Console.WriteLine(AbbrevName("sam harris"));
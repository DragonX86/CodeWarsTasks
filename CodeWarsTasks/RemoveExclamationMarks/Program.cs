static string RemoveExclamationMarks(string s)
{
    return s.Replace("!", "");
}

Console.WriteLine(RemoveExclamationMarks(""));
Console.WriteLine(RemoveExclamationMarks("!"));
Console.WriteLine(RemoveExclamationMarks("!!"));
Console.WriteLine(RemoveExclamationMarks("Hi!"));
Console.WriteLine(RemoveExclamationMarks("!?!"));
/*
 * TODO:
 * Given a string of digits, you should replace any digit below 5 with '0'
 * and any digit 5 and above with '1'. Return the resulting string.
 */

using System.Text;

static string FakeBin(string x)
{
    var result = "";
    
    foreach (var letter in x)
    {
        var digit = int.Parse(letter.ToString());

        if (digit >= 5)
            result += "1";
        else
            result += "0";
    }
    return result;
}

Console.WriteLine();

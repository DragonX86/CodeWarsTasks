static int[] CountPositivesSumNegatives(int[]? input)
{
    if (input == null || input.Length == 0)
    {
        return Array.Empty<int>();
    }
    
    var countPositivesNumbers = input.Count(i => i > 0);
    var sumNegativesNumbers = input.Where(i => i < 0).Sum();
    
    return new[]
    {
        countPositivesNumbers, 
        sumNegativesNumbers
    };
}

var result = CountPositivesSumNegatives(Array.Empty<int>());
Console.WriteLine(string.Join(",", result));
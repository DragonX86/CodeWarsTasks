static int GetSum(int a, int b)
{
    int max = Math.Max(a, b);
    int min = Math.Min(a, b);
    int result = 0; 
    
    for (var i = min; i <= max; i++){
        result += i;
    }      
    return result;
}

Console.WriteLine(Enumerable.Range(-1, 2).Sum());
// Console.WriteLine($"1 = {GetSum(0, 1)}");
// Console.WriteLine($"-1 = {GetSum(0, -1)}");
/*
 * TODO:
 * Your task is to calculate how many blank pages do you need. If n < 0 or m < 0 return 0.
 */

static int Paperwork(int n, int m)
{
    return !(n < 0 || m < 0) ? n * m : 0;
}

Console.WriteLine(Paperwork(5,5));
Console.WriteLine(Paperwork(5,-5));
Console.WriteLine(Paperwork(-5,-5));
Console.WriteLine(Paperwork(-5,5));
Console.WriteLine(Paperwork(5,0));






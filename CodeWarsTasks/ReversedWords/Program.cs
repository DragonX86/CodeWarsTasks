/*
 * TODO:
 * Complete the solution so that it reverses all of the words within the string passed in. 
 */
 
static string ReverseWords(string str) => string.Join(" ", str.Split().Reverse());

Console.WriteLine(ReverseWords("hello world!"));
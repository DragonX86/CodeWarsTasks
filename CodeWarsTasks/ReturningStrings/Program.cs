﻿/*
 * TODO:
 * Make a function that will return a greeting statement that uses an input;
 *  your program should return, "Hello, <name> how are you doing today?".
 */

string Greet(string name)
{
    return $"Hello, {name} how are you doing today?";
}

var name = Console.ReadLine();
Console.WriteLine(Greet(name));
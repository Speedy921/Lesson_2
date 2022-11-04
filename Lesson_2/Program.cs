using System;
using System.Text;

BasicStringFunctionality();

static void BasicStringFunctionality()
{
    Console.WriteLine("=> Basic String functionality:");
    string firstName = "Artem";
    // вывод значения firstName.
    Console.WriteLine("Value of firstName: {0}", firstName);
    // вывод длины firstName.
    Console.WriteLine("firstName has {0} characters.", firstName.Length);
    // вывод firstName в верхнем регистре
    Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
    // вывод firstName в нижнем регистре
    Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
    // Содержит ли firstName букву У?
    Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
    // вывод firstName после замены 
    Console.WriteLine("New first name: {0}", firstName.Replace("em",""));
    Console.WriteLine();
}
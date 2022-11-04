using System;
using System.Text;

BasicStringFunctionality();
StringConcatenation();
EscapeChars();

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

static void StringConcatenation() //конкатенация строк
{
    Console.WriteLine("=>String concatenation:");
    string s1 = "Programming the";
    string s2 = "PsychoDrill (PTP)";
    string s3 = String.Concat(s1, s2);
    Console.WriteLine(s3);
    Console.WriteLine();
}

static void EscapeChars() //использование управляющих последовательностей
{
    Console.WriteLine("Escape characters:\a");
    string strWithTabs = "Model\tColor\tSpeed\tPet Name\a";
    Console.WriteLine(strWithTabs);
    Console.WriteLine("Everyone loves \"Hello World\"\a");
    Console.WriteLine("C:\\MyApp\\bin\\Debug\a");
    // Добавить 4 пустых строки и снова выдать звуковой сигнал
    Console.WriteLine("All finished. \n\n\n\a");
    Console.WriteLine();
}
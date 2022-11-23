using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

BasicStringFunctionality();
StringConcatenation();
EscapeChars();
StringInterpolation();
StringVerbatim();
StringEqality();
StringEqualitySpecifingCompareRules();
StringAreImmutable();
FunWithStringBuilder();

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

static void StringInterpolation() //Интерполяция строк
{
    //некоторые локальные переменные будут включены в крупную сроку 
    int age = 22;
    string name = "Ann";

    //Использование синтаксиса с фигурными скобками.
    string greeting = string.Format("Hello {0} you are {1} years old.", name, age);

    //Использование интерполяции строк
    string greeting2 = $"Hello {name} you are {age} years old.";

    string greeting3 = string.Format("Hello {0} you are {1} years old.", name.ToUpper(), age);

    string greeting4 = $"Hello {name.ToUpper()} you are {age} years old.";
}

static void StringVerbatim()
{
    //Следующая строка возпроизводится дословно, так что отображаются все упарвл символы.
    Console.WriteLine(@"C:\MyApp\bin\Debug");

    //При использовании дословных строк пробельные символы предохраняются
    string myLongstring = @"This is a very
                    very
                          very
                                very long string";
    Console.WriteLine(myLongstring);

    //совмещаются с интерполяцией
    string interp = "interpolation";
    string MyLongstring2 = $@"This is a very 
                    very        
                        long string with {interp}";
}

static void StringEqality()
{
    Console.WriteLine("=> String equality:");
    string s1 = "Hello!";
    string s2 = "Yo";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();

    //Проверить строки на равенство
    Console.WriteLine("s1 == s2: {0}", s1 == s2);
    Console.WriteLine("s1 == Hello!: {0}",s1 == "Hello!");
    Console.WriteLine("s1 == HELLO!: {0}",s1 == "HELLO!");
    Console.WriteLine("s1 == hello!: {0}",s1 == "hello!");
    Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
    Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));
    Console.WriteLine();
}

//модификация поведения сравнения строк
static void StringEqualitySpecifingCompareRules()
{
    Console.WriteLine(" => String equality (Case Intensitive:");
    string s1 = "Hello!";
    string s2 = "HELLO!";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();

    //проверить результаты изменения стандартных правил сравнения.
    Console.WriteLine("Default rules: s1={0}, s2={1}s1.Equals(s2): {2}", s1,s2, s1.Equals(s2));
    Console.WriteLine("Ignore case: s1.Equals(s2, StringComparion.OrdinalIgnoreCase): {0}", s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("ignore case, Invariant ulture: s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}", s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
    Console.WriteLine();
    Console.WriteLine("Default rules: s1={0}, s2=(1) s1.IndexOf(\"E\"): {2}", s1, s2, s1.IndexOf("E"));
    Console.WriteLine("Ignore case: s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase): {0}", s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("Ignore case, Invariant Culture: s1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase): {0}", s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
    Console.WriteLine();

}

//строки неизменяемы
static void StringAreImmutable()
{
    Console.WriteLine("=> Immutable Strings: \a");
    //начальное значение для строки
    string s1 = "This is my string.";
    Console.WriteLine("s1 = {0}", s1);

    //преобразована ли строка s1 в верхний регистр?
    string upperString = s1.ToUpper();
    Console.WriteLine("upperString = {0}", upperString);

    //Нет! Строка s1 осталасьв том же виде!
    Console.WriteLine("s1 = {0}",s1);
}

static void FunWithStringBuilder() //тип System.StringBuilder
{
    Console.WriteLine("=> Using the StringDuilder:");
    StringBuilder sb = new StringBuilder("****Fantastic Games*****");
    sb.Append("\n");
    sb.AppendLine("Half Life");
    sb.AppendLine("Morrowind");
    sb.AppendLine("Deus Ex" + "2");
    sb.AppendLine("System Shock");
    Console.WriteLine(sb.ToString());
    sb.Replace("2","Invisible War");
    Console.WriteLine(sb.ToString());
    Console.WriteLine("sb has {0} chars.", sb.Length);
    Console.WriteLine();

}


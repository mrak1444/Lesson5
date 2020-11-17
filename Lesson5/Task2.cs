using System;
using System.Text.RegularExpressions;

class Task2
{
    private bool Check(string log)
    {
        Regex regex = new Regex(@"^[^0-9]\w{1,9}"); //Не понял почему проходит проверку только пароль с заглавной буквой.
        return regex.IsMatch(log);
    }
    public void Run()
    {
        Console.WriteLine("Введи свой логин");
        string log = Console.ReadLine();
        Console.WriteLine(Check(log));
        Console.ReadKey();
    }
}

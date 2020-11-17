using System;

class Task1
{
    private bool Check(string log)
    {
        if(log.Length <= 2 || log.Length > 10 || log[0] >= '0' && log[0] <= '9')
        {
            return false;
        }
        else
        {
            bool flag = true;
            for (int i = 0; i < log.Length; i++)
            {
                if (log[i] >= 'а' && log[i] <= 'я')
                {
                    flag = false;
                    break;
                }

            }
            return flag;
        }
    }
    public void Run()
    {
        Console.WriteLine("Введи свой логин");
        string log = Console.ReadLine();
        Console.WriteLine(Check(log));
        Console.ReadKey();
    }
}

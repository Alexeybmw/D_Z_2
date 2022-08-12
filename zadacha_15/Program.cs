Console.Write("Введите день недели:");
int day = Convert.ToInt32(Console.ReadLine());

void week (int day)
{
    if(day == 6 || day == 7)
    {
        Console.WriteLine("(Выходной) -> Да");
    }
       
    else  Console.WriteLine("(Выходной) -> Нет "); 

}
week(day);
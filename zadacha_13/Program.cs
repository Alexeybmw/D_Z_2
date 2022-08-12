Console.WriteLine("Введите число:");
int Num = Convert.ToInt32(Console.ReadLine());
string Number = Convert.ToString(Num);
{
    if (Number.Length > 2 )
    {
        Console.WriteLine("Третья цифра ->"+ Number [2] );
    }
    else

    {
        Console.WriteLine("-> Третьей цифры нет ");
    }
}
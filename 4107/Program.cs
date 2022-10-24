Console.Write("Год:");
int year = Convert.ToInt32(Console.ReadLine());
Console.Write("Порядковый номер месяца:");
int mounth = Convert.ToInt32(Console.ReadLine());
switch (mounth)
{
    case 1: Console.Write("Месяц: Январь - 31 день"); break;
    case 2:
        if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        {
            Console.Write("Месяц: Февраль - 29 дней");
        }
        else
        {
            Console.Write("Месяц: Февраль - 28 дней");
        }
        break;
    case 3: Console.Write("Месяц: Март - 31 день"); break;
    case 4: Console.Write("Месяц: Апрель - 30 дней"); break;
    case 5: Console.Write("Месяц: Май - 31 день"); break;
    case 6: Console.Write("Месяц: Июнь - 30 дней"); break;
    case 7: Console.Write("Месяц: Июль - 31 день"); break;
    case 8: Console.Write("Месяц: Август - 31 день"); break;
    case 9: Console.Write("Месяц: Сентябрь - 30 дней"); break;
    case 10: Console.Write("Месяц: Октябрь - 31 день"); break;
    case 11: Console.Write("Месяц: Ноябрь - 30 дней"); break;
    case 12: Console.Write("Месяц: Декабрь - 31 день"); break;
}
//Составить программу, которая в зависимости от порядкового номера месяца (1,  2, ..., 12)
//выводит на экран количество дней в этом месяце. Рассмотреть два случая:1) год не является
//високосным (см.задачу 4.65); 2) год может быть високосным (информация об этом вводится с клавиату-ры).
// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

Console.OutputEncoding = System.Text.Encoding.UTF8;


//  Ви отримали рядок, який містить декілька слів, розділених комами.
//  Ваша мета - видалити всі пробіли з цього рядка та вивести результат.
Console.Write("Введіть вираз - ");
string? str = Console.ReadLine();


foreach (char item in str)
{

    if (item != ' ')
    {
        Console.Write(item);
    }

}

//  Ви отримали рядок, який містить ім’я та прізвище користувача.
//  Ваша мета - перевірити, чи починається прізвище на ту ж літеру, що й ім’я. Якщо так,
//  вивести повідомлення “Прізвище починається на ту ж літеру, що і ім’я”,
//  інакше - “Прізвище не починається на ту ж літеру, що і ім’я”.


Console.WriteLine("\n");
Console.Write("Введіть ім'я та прізвище - ");
string? FamalyName = Console.ReadLine();

if (FamalyName.Substring(0, 1) == FamalyName.Substring(FamalyName.IndexOf(' ') + 1, 1))
{
    Console.WriteLine($"Прізвище починається на ту ж літеру, що і ім’я на літеру \"{FamalyName.Substring(0, 1)}\"!");
}
else
{
    Console.WriteLine($"Прізвище не починається на ту ж літеру, що і ім’я!");
}






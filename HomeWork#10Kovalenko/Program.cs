// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введіть вираз - ");
string? str = Console.ReadLine();


foreach (char item in str)
{

    if (item != ' ')
    {
        Console.Write(item);
    }

}





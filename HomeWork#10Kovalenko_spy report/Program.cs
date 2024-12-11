// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using System.Text;
Console.OutputEncoding = System.Text.Encoding.UTF8;



//string inputReport = Console.ReadLine();
//string inputReport = "Звіт перший | ";
//Console.WriteLine(inputReport);
StringBuilder Report = new StringBuilder();

int nubmberReport = 0;
while (true)
{
    nubmberReport++;
    Console.Clear();
    Console.Write($"Звіт № {nubmberReport}!\nВведення даних: {DateTime.UtcNow} - ");

    Report = Report.Append($"{DateTime.UtcNow} - Звіт № {nubmberReport}\n|{Console.ReadLine()}|\r\n");
    Report = Report.Append("---------------------------------------------\n");



    Console.Write("\n Продожити? - 1 / Закінчити та вивести звіт? - 2 _ ");

    bool exitOut = int.TryParse((Console.ReadLine()), out int exit);

    if (exit == 2)

    { break; }

    else if (exit == 1)

    { continue; }
    else if (!exitOut)
    {
        Console.Clear();
        Console.WriteLine("Невірний вибір, програму буде завершено, а звіт буде виведний на екран...");
        Console.ReadKey();
        break;
    }
}
Console.Clear();
Console.WriteLine( Report);
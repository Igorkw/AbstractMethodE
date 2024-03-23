using AbstractMethodE.Entities;
using System.Globalization;

List<TaxPayer> taxPayers = new List<TaxPayer>();

Console.Write("Type the number of tax payers: ");
int nPayers = int.Parse(Console.ReadLine());

for (int i = 1; i <= nPayers; i++)
{
    Console.WriteLine($"Tax payer #{1} data:");
    Console.Write("Individual or company (i/c)? ");
    string ioc = Console.ReadLine();

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Anual Income: ");
    double aIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (ioc == "i")
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        taxPayers.Add(new NaturalPerson(name, aIncome, healthExpenditures));
    }
    else
    {
        Console.Write("Number of employees: ");
        int nEmployees = int.Parse(Console.ReadLine());

        taxPayers.Add(new LegalPerson(name, aIncome, nEmployees));
    }

}

double sum = 0.0;
Console.WriteLine("\nTaxes paid: ");

foreach (TaxPayer t in taxPayers)
{
    double tax = t.TaxCalculation();
    Console.WriteLine($"{t.Name}: $ {tax.ToString("F2", CultureInfo.InvariantCulture)}");
    sum += tax;
}

Console.WriteLine($"\nTOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
namespace AbstractMethodE.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer(string name, double anualIncome)
        {
            name = Name;
            anualIncome = AnualIncome;
        }

        public abstract double TaxCalculation();
    }
}

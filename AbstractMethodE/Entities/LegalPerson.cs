namespace AbstractMethodE.Entities
{
    class LegalPerson : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public LegalPerson(string name, double anualIncome, int numberOfEmployees) :base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double TaxCalculation()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14; 
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}

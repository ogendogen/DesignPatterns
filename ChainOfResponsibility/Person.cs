using ChainOfResponsibility.Types;

namespace ChainOfResponsibility
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double MonthIncome { get; set; }
        public Employment EmploymentType { get; set; }
        public bool HasAlreadyCredit { get; set; }
        public CreditHistory CreditHistory { get; set; }
    }
}

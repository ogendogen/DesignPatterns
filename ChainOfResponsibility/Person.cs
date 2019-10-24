using ChainOfResponsibility.Types;

namespace ChainOfResponsibility
{
    public class Person
    {
        public string Name { get; set; }
        public double MonthIncome { get; set; }
        public Employment EmploymentType { get; set; }
    }
}

using ChainOfResponsibility.Types;

namespace ChainOfResponsibility
{
    public class CreditRequest
    {
        public double Amount { get; set; }
        public double Percentage { get; set; }
        public Person Requester { get; set; }
        public int TimeInMonths { get; set; }
        public RiskLevel RiskOfInvestment { get; set; }
    }
}

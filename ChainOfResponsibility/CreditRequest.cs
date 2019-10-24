using ChainOfResponsibility.Types;

namespace ChainOfResponsibility
{
    public class CreditRequest
    {
        public double Amount { get; set; }
        public double Percentage { get; set; }
        public Person Requester { get; set; }
        public CreditHistory CreditHistory { get; set; }
        public bool HasAlreadyCredit { get; set; }
    }
}

using System;
using ChainOfResponsibility;
using ChainOfResponsibility.Types;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ChainOfResponsibility();
        }

        private static void ChainOfResponsibility()
        {
            Console.WriteLine("1. CHAIN OF RESPONSIBILITY");
            Verifier verifier = new Verifier();
            Analyzer analyzer = new Analyzer();
            RiskEstimator riskEstimator = new RiskEstimator();
            verifier.SetNext(analyzer);
            analyzer.SetNext(riskEstimator);

            string refMessage = String.Empty;
            CreditRequest creditRequest = new CreditRequest
            {
                Amount = 40000,
                Percentage = 7.5,
                RiskOfInvestment = RiskLevel.Low,
                TimeInMonths = 24,
                Requester = new Person
                {
                    Name = "John",
                    LastName = "William",
                    Age = 37,
                    HasAlreadyCredit = false,
                    CreditHistory = CreditHistory.Good,
                    MonthIncome = 6250,
                    EmploymentType = Employment.Permanent
                }
            };

            verifier.Process(creditRequest, ref refMessage);
            Console.WriteLine($"John William credit request result: { refMessage }");

            CreditRequest creditRequest2 = new CreditRequest
            {
                Amount = 85000,
                Percentage = 10.5,
                RiskOfInvestment = RiskLevel.Normal,
                TimeInMonths = 12,
                Requester = new Person
                {
                    Name = "Mark",
                    LastName = "Mason",
                    Age = 29,
                    HasAlreadyCredit = false,
                    CreditHistory = CreditHistory.Good,
                    MonthIncome = 3000,
                    EmploymentType = Employment.Temporary
                }
            };

            verifier.Process(creditRequest2, ref refMessage);
            Console.WriteLine($"Mark Mason credit request result: { refMessage }");
        }
    }
}

using System;
using ChainOfResponsibility.Types;

namespace ChainOfResponsibility
{
    public class Analyzer : IBank
    {
        private IBank _nextStage;
        public void Process(CreditRequest creditRequest, ref string returnMessage)
        {
            if (IsAnalysisFine(creditRequest) && _nextStage != null)
            {
                _nextStage.Process(creditRequest, ref returnMessage);
            }
            else
            {
                returnMessage = "Analyzer failed";
            }
        }

        public void SetNext(IBank nextStage)
        {
            _nextStage = nextStage;
        }

        public bool IsAnalysisFine(CreditRequest creditRequest)
        {
            int points = 0;
            points += GetPointsForEmployment(creditRequest.Requester.EmploymentType);
            points += GetPointsForIncome(creditRequest.Requester.MonthIncome);
            points += GetPointsForAge(creditRequest.Requester.Age);
            points += GetPointsForCreditHistory(creditRequest.Requester.CreditHistory);
            points += GetPointsForCreditStatus(creditRequest.Requester.HasAlreadyCredit);
            
            return points > 8;
        }

        private int GetPointsForCreditStatus(bool hasAlreadyCredit)
        {
            return hasAlreadyCredit ? 1 : 0;
        }

        private int GetPointsForEmployment(Employment employmentType)
        {
            return (int)employmentType;
        }
        
        private int GetPointsForIncome(double monthIncome)
        {
            if (monthIncome < 2000)
            {
                return 0;
            }
            if (monthIncome >= 2000 && monthIncome < 4000) 
            {
                return 1;
            }
            else if (monthIncome >= 4000 && monthIncome < 6000)
            {
                return 2;
            }
            else if (monthIncome >= 6000 && monthIncome < 8000)
            {
                return 3;
            }
            else if (monthIncome > 8000 && monthIncome < 10000)
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }
        
        private int GetPointsForAge(int age)
        {
            return age > 35 ? 1 : 0;
        }

        private int GetPointsForCreditHistory(CreditHistory creditHistory)
        {
            return (int)creditHistory;
        }
    }
}

using ChainOfResponsibility.Types;

namespace ChainOfResponsibility
{
    public class RiskEstimator : IBank
    {
        private IBank _nextStage;
        public void Process(CreditRequest creditRequest, ref string returnMessage)
        {
            if (IsRiskEstimatedOk(creditRequest))
            {
                returnMessage = "Credit acquired";
            }
            else
            {
                returnMessage = "RiskEstimator failed";
            }
            
            if (_nextStage != null)
            {
                _nextStage.Process(creditRequest, ref returnMessage);
            }
        }

        private bool IsRiskEstimatedOk(CreditRequest creditRequest)
        {
            switch(creditRequest.RiskOfInvestment)
            {
                case RiskLevel.Low:
                    {
                        return creditRequest.Amount <= 500000 && creditRequest.Percentage >= 15.0 && creditRequest.TimeInMonths >= 36;
                    }
                case RiskLevel.Normal:
                    {
                        return creditRequest.Amount <= 250000 && creditRequest.Percentage >= 12.0 && creditRequest.TimeInMonths >= 24;
                    }
                case RiskLevel.High:
                    {
                        return creditRequest.Amount <= 100000 && creditRequest.Percentage >= 10.0 && creditRequest.TimeInMonths >= 24;
                    }
                case RiskLevel.VeryHigh:
                    {
                        return creditRequest.Amount <= 75000 && creditRequest.Percentage >= 8.0 && creditRequest.TimeInMonths >= 12;
                    }
                default:
                    {
                        return false;
                    }
            }
        }

        public void SetNext(IBank nextStage)
        {
            _nextStage = nextStage;
        }
    }
}

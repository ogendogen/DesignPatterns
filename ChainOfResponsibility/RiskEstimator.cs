using System;
using System.Collections.Generic;
using System.Text;

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
            else if (_nextStage != null)
            {
                _nextStage.Process(creditRequest, ref returnMessage);
            }
        }

        private bool IsRiskEstimatedOk(CreditRequest creditRequest)
        {
            throw new NotImplementedException();
        }

        public void SetNext(IBank nextStage)
        {
            _nextStage = nextStage;
        }
    }
}

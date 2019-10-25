using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class Analyzer : IBank
    {
        private IBank _nextStage;
        public void Process(CreditRequest creditRequest, ref string errorMessage)
        {
            if (IsAnalysisFine(creditRequest))
            {
                _nextStage.Process(creditRequest, ref errorMessage);
            }
            else
            {
                errorMessage = "Analyzer failed";
            }
        }

        public void SetNext(IBank nextStage)
        {
            _nextStage = nextStage;
        }

        public bool IsAnalysisFine(CreditRequest creditRequest)
        {
            throw new NotImplementedException();
        }
    }
}

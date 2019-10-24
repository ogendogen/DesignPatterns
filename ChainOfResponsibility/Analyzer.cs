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
            throw new NotImplementedException();
        }

        public void SetNext(IBank nextStage)
        {
            _nextStage = nextStage;
        }
    }
}

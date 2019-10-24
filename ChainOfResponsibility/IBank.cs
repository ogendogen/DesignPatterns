using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public interface IBank
    {
        abstract void Process(CreditRequest creditRequest, ref string errorMessage);
        abstract void SetNext(IBank nextStage);
    }
}

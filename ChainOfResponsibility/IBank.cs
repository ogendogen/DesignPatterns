using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public interface IBank
    {
        abstract void Process();
        abstract void SetNext(IBank nextStage);
    }
}

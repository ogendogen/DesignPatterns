using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    interface IBank
    {
        abstract void process();
        abstract void doNext(IBank nextStage);
    }
}

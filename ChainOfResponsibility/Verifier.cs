using System;

namespace ChainOfResponsibility
{
    public class Verifier : IBank
    {
        public void doNext(IBank nextStage)
        {
            throw new NotImplementedException();
        }

        public void process()
        {
            throw new NotImplementedException();
        }
    }
}

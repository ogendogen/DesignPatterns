using System;

namespace ChainOfResponsibility
{
    public class Verifier : IBank
    {
        public void SetNext(IBank nextStage)
        {
            throw new NotImplementedException();
        }

        public void Process()
        {
            throw new NotImplementedException();
        }
    }
}

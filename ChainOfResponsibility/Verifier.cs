using System;

namespace ChainOfResponsibility
{
    public class Verifier : IBank
    {
        public IBank NextStage { get; set; }
        public void SetNext(IBank nextStage)
        {
            NextStage = nextStage;
        }

        public void Process(CreditRequest creditRequest, ref string errorMessage)
        {
            if (IsDataVerified(creditRequest))
            {
                NextStage.Process(creditRequest, ref errorMessage);
            }
            else
            {
                errorMessage = "Verifier failed";
            }
        }

        public bool IsDataVerified(CreditRequest creditRequest)
        {
            return IsPersonalDataValid(creditRequest.Requester);
        }

        public bool IsPersonalDataValid(Person person)
        {
            return !String.IsNullOrEmpty(person.Name) || !String.IsNullOrEmpty(person.LastName) || person.Age >= 18;
        }
    }
}

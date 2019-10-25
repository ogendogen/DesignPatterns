using System;

namespace ChainOfResponsibility
{
    public class Verifier : IBank
    {
        private IBank _nextStage;
        public void SetNext(IBank nextStage)
        {
            _nextStage = nextStage;
        }

        public void Process(CreditRequest creditRequest, ref string returnMessage)
        {
            if (IsDataVerified(creditRequest) && _nextStage != null)
            {
                _nextStage.Process(creditRequest, ref returnMessage);
            }
            else
            {
                returnMessage = "Verifier failed";
            }
        }

        private bool IsDataVerified(CreditRequest creditRequest)
        {
            return IsPersonalDataValid(creditRequest.Requester) &&
                   AreNamesCorrect(creditRequest.Requester) &&
                   IsEmployed(creditRequest.Requester) &&
                   IsProperIncome(creditRequest.Requester);
        }

        private bool IsPersonalDataValid(Person person)
        {
            return !String.IsNullOrEmpty(person.Name) || 
                   !String.IsNullOrEmpty(person.LastName) || 
                   person.Age >= 18;
        }

        private bool AreNamesCorrect(Person person)
        {
            return Char.IsUpper(person.Name[0]) &&
                   Char.IsUpper(person.LastName[0]);
        }

        private bool IsEmployed(Person person)
        {
            return person.EmploymentType != Types.Employment.None;
        }

        private bool IsProperIncome(Person person)
        {
            return person.MonthIncome > 2000;
        }
    }
}

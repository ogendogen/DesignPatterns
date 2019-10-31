using System;
using ChainOfResponsibility;
using ChainOfResponsibility.Types;
using Builder;
using Composite;
using Composite.Types;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ChainOfResponsibility();
            Builder();
            Composite();
        }

        #region ChainOfResponsibility
        private static void ChainOfResponsibility()
        {
            Console.WriteLine("1. CHAIN OF RESPONSIBILITY");
            Verifier verifier = new Verifier();
            Analyzer analyzer = new Analyzer();
            RiskEstimator riskEstimator = new RiskEstimator();
            verifier.SetNext(analyzer);
            analyzer.SetNext(riskEstimator);

            string refMessage = String.Empty;
            CreditRequest creditRequest = new CreditRequest
            {
                Amount = 40000,
                Percentage = 7.5,
                RiskOfInvestment = RiskLevel.Low,
                TimeInMonths = 24,
                Requester = new Person
                {
                    Name = "John",
                    LastName = "William",
                    Age = 37,
                    HasAlreadyCredit = false,
                    CreditHistory = CreditHistory.Good,
                    MonthIncome = 6250,
                    EmploymentType = Employment.Permanent
                }
            };

            verifier.Process(creditRequest, ref refMessage);
            Console.WriteLine($"John William credit request result: { refMessage }");

            CreditRequest creditRequest2 = new CreditRequest
            {
                Amount = 85000,
                Percentage = 10.5,
                RiskOfInvestment = RiskLevel.Normal,
                TimeInMonths = 12,
                Requester = new Person
                {
                    Name = "Mark",
                    LastName = "Mason",
                    Age = 29,
                    HasAlreadyCredit = false,
                    CreditHistory = CreditHistory.Good,
                    MonthIncome = 3000,
                    EmploymentType = Employment.Temporary
                }
            };

            verifier.Process(creditRequest2, ref refMessage);
            Console.WriteLine($"Mark Mason credit request result: { refMessage }");
        }
        #endregion

        #region Builder
        private static void Builder()
        {
            Console.WriteLine();
            Console.WriteLine("2. BUILDER");

            CoffeeMachine coffeeMachine = new CoffeeMachine();

            Coffee cappucino = coffeeMachine.GetBigCappuccinoWithOneSpoon();
            Console.WriteLine(cappucino.ToString());
            Console.WriteLine();

            Coffee espresso = coffeeMachine.GetBigEspressoWithTwoSpoonsAndCinamon();
            Console.WriteLine(espresso.ToString());
            Console.WriteLine();

            Coffee latte = coffeeMachine.GetSmallLatteWithNoSugarExtraMilkAndDoubleCoffee();
            Console.WriteLine(latte.ToString());
            Console.WriteLine();
        }
        #endregion

        #region Composite
        private static void Composite()
        {
            Console.WriteLine();
            Console.WriteLine("3. COMPOSITE");

            Fleet fleet = new Fleet();
            Car car = new Car
            {
                ID = 1,
                Status = Status.InFleet,
            };
            car.StatusChanged += VehicleStatusChanged;

            Car car2 = new Car
            {
                ID = 2,
                Status = Status.InFleet
            };
            car2.StatusChanged += VehicleStatusChanged;

            VAN van = new VAN
            {
                ID = 3,
                Status = Status.InFleet
            };
            van.StatusChanged += VehicleStatusChanged;

            Motorbike motorbike = new Motorbike
            {
                ID = 4,
                Status = Status.InFleet
            };
            motorbike.StatusChanged += VehicleStatusChanged;

            fleet.AddVehicle(car);
            fleet.AddVehicle(car);
            fleet.AddVehicle(van);
            fleet.AddVehicle(motorbike);

            fleet.GoForClient();
            fleet.StandBy();
        }

        private static void VehicleStatusChanged(object sender, EventArgs e)
        {
            IVehicle vehicle = (IVehicle)sender;
            if (vehicle is Car car)
            {
                switch(car.Status)
                {
                    case Status.InFleet:
                        {
                            Console.WriteLine($"Car with ID {car.ID} moved to fleet");
                            break;
                        }
                    case Status.StandBy:
                        {
                            Console.WriteLine($"Car with ID {car.ID} stand by");
                            break;
                        }
                    case Status.Working:
                        {
                            Console.WriteLine($"Car with ID {car.ID} went for a client");
                            break;
                        }
                }
            }
            else if (vehicle is VAN van)
            {
                switch(van.Status)
                {
                    case Status.InFleet:
                        {
                            Console.WriteLine($"VAN with ID {van.ID} moved to fleet");
                            break;
                        }
                    case Status.StandBy:
                        {
                            Console.WriteLine($"VAN with ID {van.ID} stand by");
                            break;
                        }
                    case Status.Working:
                        {
                            Console.WriteLine($"VAN with ID {van.ID} went for a client");
                            break;
                        }
                }
            }
            else if (vehicle is Motorbike motorbike)
            {
                switch(motorbike.Status)
                {
                    case Status.InFleet:
                        {
                            Console.WriteLine($"Motorbike with ID {motorbike.ID} moved to fleet");
                            break;
                        }
                    case Status.StandBy:
                        {
                            Console.WriteLine($"Motorbike with ID {motorbike.ID} stand by");
                            break;
                        }
                    case Status.Working:
                        {
                            Console.WriteLine($"Motorbike with ID {motorbike.ID} went for a client");
                            break;
                        }
                }
            }
        }
        #endregion
    }
}

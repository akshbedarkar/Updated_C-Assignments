using static UniCastDelegate.Manager;

namespace UniCastDelegate
{
    #region Abstract Class

   
    abstract class Employee
    {
        public abstract void CalculateGrossSalary();
        public abstract void CalculateSalary();
    }
    #endregion

    class Manager : Employee
    {
        #region variable declaration

        
        private double petrolAllowance;
        private double FoodAllowance;
        private double OtherAllowance;
        private double NetSalary;
        private double salary;
        private double GrossSalary;

        #endregion

        #region constructor

       
        public Manager(int salary)
        {
            this.salary = salary;

        }
        #endregion

        #region method

        
        public void AllowancesCalculation()
        {
            this.petrolAllowance = (double)this.salary * 0.8;
            this.FoodAllowance = (double)this.salary * 0.13;
            this.OtherAllowance = (double)this.salary * 0.03;
        }

        public override void CalculateGrossSalary()
        {
            AllowancesCalculation();
            this.GrossSalary = (double)this.petrolAllowance + (double)this.FoodAllowance + (double)this.OtherAllowance;
        }

        public override void CalculateSalary()
        {
            this.NetSalary = (double)this.petrolAllowance + (double)this.FoodAllowance + (double)this.OtherAllowance;
        }

        public delegate void printdelegate();
        public void printdetails()
        {
            Console.WriteLine($"Details from Manager : \n petrol Allowance: {petrolAllowance} \n Food Allowance {FoodAllowance} \n Other Allowance {OtherAllowance} \n net salary {NetSalary}\n Gross Salary {GrossSalary}\n ");
        }

        #endregion
    }
    class MarketingExecative : Employee
    {

        #region Variable Declaration

        
        private int KilometerTravel;
        private int TourAllowance;
        private int TelephoneAllowance;
        private double GrossSalary;
        private double NetSalary;
        private int salary;

        #endregion

        #region constructor
        public MarketingExecative(int salary, int KilometerTravel)
        {
            this.salary = salary;
            this.KilometerTravel = KilometerTravel;
        }
        #endregion

        #region method

        public void AllowancesCalculation()
        {
            this.TourAllowance = 5 * this.KilometerTravel;
            this.TelephoneAllowance = 1000;
        }

        public override void CalculateGrossSalary()
        {
            AllowancesCalculation();
            this.GrossSalary = (double)this.TourAllowance + (double)this.KilometerTravel + (double)this.TelephoneAllowance;
        }

        public override void CalculateSalary()
        {
            this.NetSalary = (double)this.TourAllowance + (double)this.KilometerTravel + (double)this.TelephoneAllowance;
        }

        public delegate void printdelegate();
        public void printdetails()
        {
            Console.WriteLine($"Details from MarketingExecative : \n Tour Allowance: {TourAllowance} \n Kilometer Travel {KilometerTravel} \n Telephone Allowance {TelephoneAllowance} \n Net Salary {NetSalary}\n Gross Salary {GrossSalary}\n ");
        }

        #endregion
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter the your salary");
                int salary = int.Parse(Console.ReadLine());
                Manager m1 = new Manager(salary);
                Console.WriteLine("Enter the distance you have travelled in Km");
                int KilometerTravel = int.Parse(Console.ReadLine());
                MarketingExecative m2 = new MarketingExecative(salary, KilometerTravel);
                m2.CalculateGrossSalary();
                m2.CalculateSalary();
                m1.CalculateGrossSalary();
                m1.CalculateSalary();
                printdelegate p1 = new printdelegate(m1.printdetails);
                p1 += m2.printdetails;
                printdelegate p2 = new printdelegate(m2.printdetails);


                p1.Invoke();

            }
            catch(Exception e)
            {
                Console.WriteLine("Error Message"+e.Message);
            }
            







        }
    }
}
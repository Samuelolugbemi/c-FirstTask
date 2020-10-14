namespace EmployeeTest
{
    public class Employee
    {
        string firstName;
        string lastName;
        decimal monthlySalary;

        public Employee(string firstName, string lastName, decimal monthlySalary){
            this.firstName = firstName;
            this.lastName = lastName;
            this.monthlySalary = monthlySalary;
        }
            public string LastName{
                get{
                    return lastName;
                }
                set{
                    lastName = value;
                }
            }
            public string FirstName{
                get{
                    return firstName;
                }
                set{
                    firstName = value;
                }
            }

            public decimal MonthlySalary{
                get{
                    return monthlySalary;
                }
                set{
                    if(monthlySalary > 0.0M){
                    monthlySalary = value;
                    }
                }
            }

            public void GetYearlySalary(){
                System.Console.WriteLine($"{firstName} {lastName} your Yearly Salary : {monthlySalary * 12:C}");
            }

            public decimal TenPercentRaise(){
                decimal raise = 0.1M * monthlySalary;
                monthlySalary = monthlySalary + raise;
                return monthlySalary;
            }
    }
}
using system;

public class Employee
{
    public string firstName;
    public string lastName;
    public string Email;

    public void PrintName()
    {
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(Email);
            
    }
}

public class ParttTimeEmplyee : Employee
{
    public float HourlyWage;
}

public class FullTimeEmployee : Employee
{
    public float YearlySalary;
}

public class Program
{
    public static void main()
    {
        ParttTimeEmplyee PE = new ParttTimeEmplyee();
        FullTimeEmployee FE = new FullTimeEmployee();

	PE.firstName = "Ameya";
	PE.lastName = "Tanavade";
	PE.Email = "ameyatanavade@gmail.com";
	
	PE.PrintName();

	PE.firstName = "Rohan";
	PE.lastName = "Pingal";
	PE.Email = "rohanpingal@gmail.com";
	
	FE.PrintName();
	Console.Readline();
   }
}

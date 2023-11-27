using ConsoleTables;

namespace EmployeeNames
{
    class EmployeeDetails
    {
        public string? name, job, email, phone;

        public EmployeeDetails(string? name, string? job, string? email, string? phone)
        {
            this.name = name;
            this.job = job;
            this.email = email;
            this.phone = phone;
        }
    }

    internal class EmployeeBadge
    {
        public static EmployeeDetails? EmployeeDetailsInstance;

        public static void GetSetDetials()
        {
            EmployeeDetailsInstance = new EmployeeDetails(null, null, null, null);
            GetSetName();
            GetSetJob();
            GetSetEmail();
            GetSetPhone();
            Console.WriteLine("Name Badge:");
            // note: table is an installed package!
            var table = new ConsoleTable("name", "job", "email", "phone");
            table.AddRow(EmployeeDetailsInstance.name, EmployeeDetailsInstance.job, EmployeeDetailsInstance.email, EmployeeDetailsInstance.phone);
            table.Write();
            // 
            Console.WriteLine($"Hello {EmployeeDetailsInstance.name}");
        }
        // note: I have added `!` to say I know it's a null value here
        private static void GetSetName()
        {
            Console.WriteLine("Input Name:");
            EmployeeDetailsInstance!.name = Console.ReadLine();
        }
        private static void GetSetJob()
        {
            Console.WriteLine("Input Job:");
            EmployeeDetailsInstance!.job = Console.ReadLine();
        }
        private static void GetSetEmail()
        {
            Console.WriteLine("Input Email:");
            EmployeeDetailsInstance!.email = Console.ReadLine();
        }
        private static void GetSetPhone()
        {
            Console.WriteLine("Input Phone:");
            EmployeeDetailsInstance!.phone = Console.ReadLine();
        }
    }
}

using System ;

namespace ideaofclass
{ 
    class Program
    {
         static void Main (string[] args)
        {
            // Soz Dizimi
            // class SinifAdi
            // Property [erisim belirleyici] [veri tipi] Ozellik adi ;
            // [erisim belirleyici] [Geri Donus tipi] MethodAdi (Parametre listesi) 
            // {
            //method komutlari
            //}
            //Erisim Belirleyiciler
            //* Public
            //* Private
            //* Internal
            //* Protected
            Employee employee1 = new Employee () ;
            employee1.Name = "Baris" ;
            employee1.Surname = "Demirkap" ;
            employee1.No = 1 ;
            employee1.Department = "Test Team" ;
            employee1.EmployeeInfo () ;
            Console.WriteLine("***********************") ;
            
            Employee employee2 = new Employee () ;
            employee2.Name = "Ceros" ;
            employee2.Surname = "Yesiloren" ;
            employee2.No = 3 ;
            employee2.Department = "Food Industries" ;
            employee2.EmployeeInfo () ;


        }
    }

    class Employee
        {
                public  string Name;
                public  string Surname ;
                public  int No;
                public  string Department ;

            public  void EmployeeInfo ()
            {
                Console.WriteLine("Name of Employee:{0}" , Name) ;
                Console.WriteLine("Surname of Employee:{0}" , Surname) ;
                Console.WriteLine("Number of Employee:{0}" , No) ;
                Console.WriteLine("Department of Employee:{0}" , Department) ;
            }
        }


}
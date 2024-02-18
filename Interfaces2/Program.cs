


namespace Interfaces2
{
    class Program
    {
        //  interfaces new' lenemez
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();        

            //IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Add(new InternManager());
            projectManager.Add(new EmployeeManager());

        }
    }



    interface IPersonManager
    {
        // unimplemented operation
        void Add();
        void Update();

    }

    // Inherits - class -------- implements - interface

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            // müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }


    }


}
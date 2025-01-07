class Program
{
    static public void Main()
    {
        try
        {
            var reader = new Reader();
            var counter = new SpaceCounter();

            IService service1 = new ServiceTask1(reader, counter);
            IService service2 = new ServiceTask2(reader, counter);
            IService service3 = new ServiceTask3(counter);

            var app1 = new App(service1);
            var app2 = new App(service2);
            var app3 = new App(service3);

            app1.AsyncRun();
            app2.AsyncRun();
            app3.AsyncRun();

            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();

            Console.WriteLine("----------");
            Console.WriteLine("----------");
            Console.WriteLine("----------");
            Console.WriteLine("----------");

            app1.AsyncRun();
            Console.ReadKey();
            app2.AsyncRun();
            Console.ReadKey();
            app3.AsyncRun();
            Console.ReadKey();


        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}


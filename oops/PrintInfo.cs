namespace OOPS
{
    public class PrintInfo{
        public void Print(ITest test)
        {
            Console.WriteLine("Name: " + test.Name());
            Console.WriteLine("Address: " + test.Address());
        }
    }
}
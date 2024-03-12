using System.Collections;
namespace MyDotnet
{
    class Hashtableex
    {
        public void htex(){
            Hashtable ht1 = new Hashtable();

            ht1.Add("PId", 45);
            ht1.Add("Name","Rohit");
            ht1.Add("Team","India");
            System.Console.WriteLine("Elements:");
            foreach (DictionaryEntry item in ht1)
            {
                System.Console.WriteLine($"Key: {item.Key},Value:{item.Value}");
            }

            Hashtable ht2 = new Hashtable(){
                {"PID","45,18,7"},{"PName","Rohit,Virat,MS"},{"Team","India,India,India"}
            };
            foreach (DictionaryEntry a in ht2)
            {
                System.Console.WriteLine($"Key:{a.Key} Value:{a.Value}");
            }
        }
    }
}
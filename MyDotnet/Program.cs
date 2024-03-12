using System;

namespace MyDotnet
{   
    public delegate void practiceDelegate(int first, int second);
    public delegate string NewAnonDelegate(string name);
    class Program
    {
        static object obj1 = new object();
        static void Main(string[] args)
        {
            // Arraylist al2 = new Arraylist();
            // al2.arraylistex();

            Hashtableex htex1 = new Hashtableex();
            htex1.htex();
            // practiceDelegate practice = new practiceDelegate(Program.delexample);
            // practice += Program.deleexample2;
            // practice(10,40);

            // NewAnonDelegate newAnonDelegate =(string name)=>{
            //     return "Hello "+ name;
            // };

            // string output = newAnonDelegate.Invoke("Dhyan");
            // System.Console.WriteLine(output);

            // Thread t1 = new Thread(method1);
            // Thread t2 = new Thread(method2);
            // Thread t3 = new Thread(method3);
            // t1.Start();
            // t2.Start();
            // t3.Start();

            // int[,] abc = new int[3,2];
            // int a = 0;

            // foreach (var item in abc)
            // {
            //     System.Console.WriteLine(a +" ");
            // }
            // for (int i = 0; i < abc.GetLength(0); i++)
            // {
            //     for (int j = 0; j < abc.GetLength(1); j++)
            //     {
            //         a += 5;
            //         abc[i,j]= a;    
            //     }
            // }
            // for (int i = 0; i < abc.GetLength(0); i++)
            // {
            //     for (int j = 0; j < abc.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(abc[i,j]+" ");
            //     }
            // }

        }
         public static void delexample(int a , int b){
            System.Console.WriteLine($"{a + b}");
        }
        public static void deleexample2(int a , int b){
            System.Console.WriteLine($"{a * b}");
        }

        public static void method1(){
            lock (obj1)
            {  
                for (int i = 0; i < 4; i++)
                {
                    System.Console.WriteLine("Thread 1: " + i);
                }
            }
        }
        public static void method2(){
            lock (obj1)
            {
                for (int i = 0; i < 4; i++)
                {
                    System.Console.WriteLine("Thread 2: " +i);
                    if (i == 2)
                    {
                        Thread.Sleep(10000);
                    }
                }
            }
        }
        public static void method3(){
            lock(obj1){
                for (int i = 0; i < 4; i++)
                {
                    System.Console.WriteLine("Thread 3: " +i);
                }
            }
        }
    }
}
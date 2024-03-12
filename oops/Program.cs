namespace oops;

class Program
{
    static void Main(string[] args)
    {
        EncapExample encapExample = new EncapExample();
        encapExample.a();
        implicitConstructor obj = new implicitConstructor();
        System.Console.WriteLine($"{obj.a},{obj.b},{obj.s}");
        explicitConstructor obj1 = new explicitConstructor();
    }
}
class implicitConstructor
{
    public int a;
    public bool b;
    public string s;
}

class explicitConstructor
{
    public explicitConstructor(){
        System.Console.WriteLine("Hello Constructor");
    }
}
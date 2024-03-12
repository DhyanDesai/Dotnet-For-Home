namespace oops
{
    class EncapExample
    {
        public void a(){
            System.Console.WriteLine("Public Called");
            b();
        }
        private void b(){
            System.Console.WriteLine("Private called");
        }
    }
}
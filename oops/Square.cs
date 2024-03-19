namespace OOPS
{
    public class Square
    {
        private double Length;

        public Square(double Length){
            this.Length = Length;
        }

        public double Area()
        {
            return Length * Length;
        }    
    }
}
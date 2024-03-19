namespace OOPS
{
    public class Shape{
        private double height;
        private double width;

        public double HeightSet{
            get{return height;}
            set{height = value;}
        }

        public double WidthSet{
            get{return width;}
            set{width = value;}
        }

        public double Area(){
            return height * width;
        }
    }
}
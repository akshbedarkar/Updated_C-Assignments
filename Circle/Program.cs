namespace Circle
{
    public class Program
    {
        #region constantvariable

        const float PI= 3.14f;
        #endregion

        #region method

        
        public static void Calculate(float radius)
        {
            float area = (PI * (radius * radius));
            float circumference = 2 * PI * radius;

            Console.WriteLine($"For radius {radius} the circumference is {circumference:N1} and area is {area:N1}");

        }

        #endregion
        static void Main(string[] args)
        {
            try
            {
                Program p = new Program();
                Console.WriteLine("Enter the radius");
                float radius = float.Parse(Console.ReadLine());

                Calculate(radius);

            }
            catch(Exception e)
            {
                Console.WriteLine("Error Message"+e.Message);
            }



        }
    }
}
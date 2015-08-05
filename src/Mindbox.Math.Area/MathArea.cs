namespace Mindbox.Math.Area
{
    public class MathArea
    {
        public double GetAreaTriangle(double a, double b)
        {
            double result = 0;
            if(ValidNegative(a)
               && ValidNegative(b))
            {
                result = (a * b) / 2;
            }
            else
            {
                result = 0;
            }
            return result;
        }

        private bool ValidNegative(double number)
        {
            return number > 0;
        }
    }
}
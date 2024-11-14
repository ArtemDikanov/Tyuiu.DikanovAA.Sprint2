using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DikanovAA.Sprint2.Task7.V2.Lib
{
    public class DataService : ISprint2Task7V2
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;

            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && ((x >= -1) && (x <= 1)) && ((y >= -1) && (y <= 2 / Math.Sqrt(5))) && (((x < 0) && ((x / 2) >= y)) | ((x == 0) && ((-1 <= y) && (y <= 0))) | ((x > 0) && (y <= (x / 2)))))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}

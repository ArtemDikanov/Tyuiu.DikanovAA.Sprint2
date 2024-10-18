using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DikanovAA.Sprint2.Task1.V26.Lib
{
    public class DataService : ISprint2Task1V26
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (b > a) | (c < d); //true
            res[1] = (a < b) & (c > d); //true
            res[2] = (a + 17 == b) || (c - 5 > d); //true
            res[3] = (b - 17 >= a) && (d == c); //false
            res[4] = !res[3]; //true 
            res[5] = (a == c) ^ (d > b); //false

            return res;


        }
    }
}

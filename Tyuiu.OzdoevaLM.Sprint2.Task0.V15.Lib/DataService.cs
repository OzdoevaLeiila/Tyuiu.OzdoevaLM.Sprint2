using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.OzdoevaLM.Sprint2.Task0.V15.Lib
{
    public class DataService : ISprint2Task0V15
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y;
            res[1] = x != y + 2830;
            res[2] = x - 2831 < y;
            res[3] = x > y;
            res[4] = x <= y;
            res[5] = x >= y + 2831;
            return res;
        }
    }
}

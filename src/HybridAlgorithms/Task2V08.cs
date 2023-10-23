using System.Reflection.Metadata.Ecma335;
using System.Xml;

namespace HybridAlgorithms;

public class Task2V08
{
    public List<int> Calculate(int digitCount)
    {
        var List = new List<int>();
        for (int i = 0; i < 10000; i++)
        {
            if (IsKapricalNumber(i))
            {
                List.Add(i);
            }
        }
        throw new NotImplementedException();
    }
    bool IsKapricalNumber(int number)
    {
        string strPower = $"{number * number}";

        for (int i = 1; i < strPower.Length; i++)
        {
            int part1 =
                int.Parse(strPower.Substring(0, i));
            int part2 =
                int.Parse(strPower.Substring(i));
            if (part1 + part2 == number)
            {
                return true;
            }
        }
        return false;
    }
}

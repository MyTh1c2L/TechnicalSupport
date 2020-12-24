using System.Collections.Generic;

namespace TechnicalSupport
{
    static class DataBase
    {
        static List<string> ProblemList = new List<string>();

        static List<string> TariffList = new List<string>();

        public static void Initialize1(List<string> List)
        {
            for (int i = 1; i < List.Count; i += 2)
            {
                ProblemList.Add(List[i]);
            }
        }

        public static void Initialize2(List<string> List)
        {
            for (int i = 1; i < List.Count; i += 2)
            {
                TariffList.Add(List[i]);
            }
        }

        public static string Problem(int index)
        {
            return ProblemList[index];
        }

        public static string Tariff(int index)
        {
            return TariffList[index];
        }
    }
}

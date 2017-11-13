using System;
using System.IO;
using System.Xml.Linq;

namespace Mages_Of_Destiny
{
    public static class PlayersInfo
    {
        static string playersInfoDirectory;
        static string[][] fullInfo;
        static int [] scores;
        static int [] levels;

        //        EraseLevels()
        //        {}
        //        PrintLevels()
        //        {}
        //        RetrieveLevels()
        //        {}
        //        UpdateLevels()
        //        {}
        //        EraseScores()
        //        {}
        public static void PrintScores()
        {
            foreach (int x in scores)
            {
                Console.WriteLine(x);
            }
        }

        private static void RetrieveScores()
        {
            scores = new int[6];
            for (var i = 0; i < 6; i++)
            {
                scores[i] = Convert.ToInt32(fullInfo[0][i]);
            }
        }

        //public static void UpdateScores(int level)
        //{
        //    levels[0] = level;
        //}
        //        EraseFullInfo()
        //        {}
        //        PrintFullInfo()
        //        {}
        //        RetrieveFullInfo()
        //        {}
        //        UpdateFullInfo()
        //        {}
        //        Save()
        //        {}

        public static void Initialize()
        {
            //scores = new int[6];
            //RetrieveScores();
            //playersInfoDirectory = ($@"C:\Users\Nathan - User\OneDrive\Work - C Sharp\02 Udemy - TodV OOP with C#\Mages-Of-Destiny\Mages-Of-Destiny\");
            playersInfoDirectory = ($@"C:\Users\watenatj\OneDrive\Work - C Sharp\02 Udemy - TodV OOP with C#\Mages-Of-Destiny\Mages-Of-Destiny\");
            if (File.Exists(playersInfoDirectory + "save.txt") == false)
            {
                fullInfo = new string[][]
{
                new string[] {"10", "20", "30", "40", "50", "60"},
                new string[] {"70", "80", "90", "100", "110", "120"}
};
                Console.WriteLine("hello");
                using (StreamWriter file = new StreamWriter(playersInfoDirectory + "save.txt"))
                {
                    foreach (string[] t in fullInfo)
                    {
                        foreach (string t1 in t)
                        {
                            file.WriteLine(t1);
                        }
                    }
                    file.Close();
                }
            }
            else
            {
                fullInfo = new string[2][];
                fullInfo[0] = new string[6];
                fullInfo[1] = new string[6];
                var x = 0;
                for (var i = 0; i < 2; i++)
                {
                    for (var j = 0; j < 6; j++)
                    {
                        fullInfo[i][j] = File.ReadAllLines(playersInfoDirectory + "save.txt")[x];
                        x += 1;
                    }
                }
            }
            RetrieveScores();
        }
    }
}
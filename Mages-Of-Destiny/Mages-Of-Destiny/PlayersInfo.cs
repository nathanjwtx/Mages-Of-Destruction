using System;
using System.IO;
using System.Xml.Linq;

namespace Mages_Of_Destiny
{
    public static class PlayersInfo
    {
        static string playersInfoDirectory;
        static int [][] fullInfo;
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
        //public static void PrintScores()
        //{
        //    foreach (var item in scores)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //private static void RetrieveScores()
        //{
        //    for (int j = 0; j < 1; j++)
        //    {
        //        for (int i = 0; i < scores.Length; i++)
        //        {
        //            scores[i] = fullInfo[j, i];
        //        }
        //    }
        //}
        
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
            fullInfo = new int[][]
            {
                new int[] {1, 2, 3, 4, 5, 6 }, 
                new int[] {7, 8, 9 , 10, 11, 12}
            };
            //scores = new int[6];
            //RetrieveScores();
            playersInfoDirectory = ($@"C:\Users\Nathan - User\OneDrive\Work - C Sharp\02 Udemy - TodV OOP with C#\Mages-Of-Destiny\Mages-Of-Destiny\");
            if (File.Exists(playersInfoDirectory + "save.txt"))
            {
                Console.WriteLine("hello");
                using (StreamWriter file = new StreamWriter(playersInfoDirectory + "save.txt"))
                {
                    foreach (int[] t in fullInfo)
                    {
                        foreach (int t1 in t)
                        {
                            Console.WriteLine(t1);
                        }
                    }
                }
            }
            else
            {
                File.Create(playersInfoDirectory + "save.txt");
            }
        }
    }
}
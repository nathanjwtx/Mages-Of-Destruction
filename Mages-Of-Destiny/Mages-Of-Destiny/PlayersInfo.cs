using System;
using System.Xml.Linq;

namespace Mages_Of_Destiny
{
    public static class PlayersInfo
    {
        static string playersInfoDirectory;
        static int [,] fullInfo;
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
//        PrintScores()
//        {}
        public static int RetrieveScores()
        {
            return levels[0];
        }
        
        public static void UpdateScores(int level)
        {
            levels[0] = level;
        }
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
            fullInfo = new int[2, 6];
            scores = new int[6];
            levels = new int[6];
        }
    }
}
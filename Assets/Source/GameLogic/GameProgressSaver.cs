using System;
using UnityEngine;

namespace GameLogic
{
    public static class GameProgressSaver
    {
        private const string DifficultyLevel = "DifficultyLevel";
        private const string MuteState = "MuteState";

        public static event Action<int> DifficultyChanged;
        
        public static void SetDifficultyLevel(int difficultyLevel)
        {
            PlayerPrefs.SetInt(DifficultyLevel, difficultyLevel);
            DifficultyChanged?.Invoke(difficultyLevel);
        }

        public static int GetDifficultyLevel()
        {
            return PlayerPrefs.GetInt(DifficultyLevel);
        }

        public static void SetMuteState(bool isMuted)
        {
            var state = isMuted ? 0 : 1;
                
            PlayerPrefs.SetInt(MuteState, state);
        }

        public static bool GetMuteState()
        {
            var state = PlayerPrefs.GetInt(MuteState);

            return state == 0;
        }
    }
}
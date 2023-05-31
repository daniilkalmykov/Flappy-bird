using System.Collections.Generic;
using System.Linq;
using Player;
using UnityEngine;

namespace GameLogic
{
    public sealed class DifficultyChanger : MonoBehaviour
    {
        [SerializeField] private List<DifficultyLevel> _difficultyLevels = new();
        [SerializeField] private PipesGenerator _pipesGenerator;
        [SerializeField] private PlayerMovement _playerMovement;

        private int _currentDifficulty;

        private void Awake()
        {
            _currentDifficulty = GameProgressSaver.GetDifficultyLevel();
            
            foreach (var difficultyLevel in _difficultyLevels.Where(difficultyLevel =>
                         (int)difficultyLevel.Difficulty == _currentDifficulty))
            {
                InitObjects(difficultyLevel);
            }
        }

        private void InitObjects(DifficultyLevel difficultyLevel)
        {
            _pipesGenerator.Init(difficultyLevel.Delay, difficultyLevel.PipesCount, difficultyLevel.Prefab);
            _playerMovement.Init(difficultyLevel.PlayerSpeed);
        }
    }
}

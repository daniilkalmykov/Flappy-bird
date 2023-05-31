using Enums;
using Infrastructure;
using UnityEngine;

namespace GameLogic
{
    [CreateAssetMenu(fileName = "New DifficultyLevel", menuName = "DifficultyLevel/Create new difficulty level", order = 52)]
    public sealed class DifficultyLevel : ScriptableObject
    {
        [field: SerializeField] public float PlayerSpeed { get; private set; }
        [field: SerializeField] public float Delay { get; private set; }
        [field: SerializeField] public int PipesCount { get; private set; }
        [field: SerializeField] public Pipe Prefab { get; private set; }
        [field: SerializeField] public Difficulty Difficulty{ get; private set; }
    }
}
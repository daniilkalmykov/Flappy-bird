using System;
using GameLogic;
using UnityEngine;

namespace Player
{
    public sealed class PlayerScore : MonoBehaviour
    {
        private int _score;

        public event Action<int> ScoreChanged;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out ScoreTrigger _) == false)
                return;
            
            _score++;
            ScoreChanged?.Invoke(_score);
        }
    }
}
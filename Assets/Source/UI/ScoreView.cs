using Player;
using TMPro;
using UnityEngine;

namespace UI
{
    public sealed class ScoreView : MonoBehaviour
    {
        [SerializeField] private PlayerScore _playerScore;

        private TMP_Text _scoreText;

        private void Awake()
        {
            _scoreText = GetComponent<TMP_Text>();
        }

        private void OnEnable()
        {
            _playerScore.ScoreChanged += OnScoreChanged;
        }

        private void OnDisable()
        {
            _playerScore.ScoreChanged -= OnScoreChanged;
        }

        private void OnScoreChanged(int score)
        {
            _scoreText.text = score.ToString();
        }
    }
}
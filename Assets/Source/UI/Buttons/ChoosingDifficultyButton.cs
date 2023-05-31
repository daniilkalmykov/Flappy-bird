using Enums;
using GameLogic;
using UnityEngine;

namespace UI.Buttons
{
    public sealed class ChoosingDifficultyButton : UIButton
    {
        [SerializeField] private Difficulty _difficulty;

        protected override void OnEnable()
        {
            base.OnEnable();
            
            GameProgressSaver.DifficultyChanged += OnDifficultyChanged;
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            
            GameProgressSaver.DifficultyChanged += OnDifficultyChanged;
        }

        private void Start()
        {
            if ((int)_difficulty == GameProgressSaver.GetDifficultyLevel())
                Button.interactable = false;
        }

        protected override void OnClick()
        {
            ChooseDifficulty();
        }

        private void ChooseDifficulty()
        {
            GameProgressSaver.SetDifficultyLevel((int)_difficulty);
            Button.interactable = false;
        }

        private void OnDifficultyChanged(int difficulty)
        {
            if (difficulty != (int)_difficulty)
                Button.interactable = true;
        }
    }
}
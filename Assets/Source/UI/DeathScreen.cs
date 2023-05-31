using Player;
using UnityEngine;

namespace UI
{
    [RequireComponent(typeof(CanvasGroup))]
    public sealed class DeathScreen : MonoBehaviour
    {
        [SerializeField] private PlayerHealth _playerHealth;
        
        private CanvasGroup _canvasGroup;
        
        private void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();
        }

        private void OnEnable()
        {
            _playerHealth.Died += OnDied;
        }

        private void OnDisable()
        {
            _playerHealth.Died -= OnDied;
        }

        private void Start()
        {
            ChangeVisibility(false);
        }

        private void OnDied()
        {
            ChangeVisibility(true);
        }

        private void ChangeVisibility(bool isEnabled)
        {
            _canvasGroup.interactable = isEnabled;
            _canvasGroup.blocksRaycasts = isEnabled;
            
            _canvasGroup.alpha = isEnabled ? 1 : 0;
        }
    }
}
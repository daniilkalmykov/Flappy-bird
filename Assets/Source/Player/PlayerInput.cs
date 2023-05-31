using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(PlayerMovement))]
    public sealed class PlayerInput : MonoBehaviour
    {
        private PlayerMovement _playerMovement;

        private void Awake()
        {
            _playerMovement = GetComponent<PlayerMovement>();
        }

        private void Update()
        {
            if (Input.touchCount <= 0)
            {
                _playerMovement.MoveDown();
                return;
            }
            
            foreach (var touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                    _playerMovement.MoveUp();
                else
                    _playerMovement.MoveDown();                    
            }
        }
    }
}
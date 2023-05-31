using System;
using Infrastructure;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(PlayerInput))]
    public sealed class PlayerHealth : MonoBehaviour
    {
        private PlayerInput _playerInput;

        public event Action Died; 

        private void Awake()
        {
            _playerInput = GetComponent<PlayerInput>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out Ground _) == false && other.TryGetComponent(out Pipe _) == false)
                return;

            _playerInput.enabled = false;
            Died?.Invoke();
            
            Time.timeScale = 0;
        }
    }
}
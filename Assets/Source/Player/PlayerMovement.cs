using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(PlayerRotation), typeof(Rigidbody2D))]
    public sealed class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _jumpForce;

        private float _speed;
        private Rigidbody2D _rigidbody2D;
        private PlayerRotation _playerRotation;

        private void Awake()
        {
            _playerRotation = GetComponent<PlayerRotation>();
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        public void MoveUp()
        {
            _rigidbody2D.velocity = new Vector2(_speed, 0);
            _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Force);
            
            _playerRotation.RotateUp();
        }

        public void MoveDown()
        {
            _playerRotation.RotateDown();
        }

        public void Init(float speed)
        {
            _speed = speed;
        }
    }
}

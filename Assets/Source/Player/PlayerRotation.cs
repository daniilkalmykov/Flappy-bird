using UnityEngine;

namespace Player
{
    public sealed class PlayerRotation : MonoBehaviour
    {
        [SerializeField] private float _minRotationZ;
        [SerializeField] private float _maxRotationZ;
        [SerializeField] private float _rotationSpeed;
        
        private Quaternion _minRotation;
        private Quaternion _maxRotation;
        
        private void Start()
        {
            _minRotation = Quaternion.Euler(0, 0, _minRotationZ);
            _maxRotation = Quaternion.Euler(0, 0, _maxRotationZ);
        }

        public void RotateDown()
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, _minRotation, _rotationSpeed * Time.deltaTime);
        }

        public void RotateUp()
        {
            transform.rotation = _maxRotation;
        }
    }
}
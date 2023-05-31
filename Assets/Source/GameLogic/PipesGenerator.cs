using Infrastructure;
using UnityEngine;

namespace GameLogic
{
    public sealed class PipesGenerator : PipesPool
    {
        [SerializeField] private float _minSpawnYPosition;
        [SerializeField] private float _maxSpawnYPosition;
        
        private Pipe _prefab;
        private float _delay;
        private int _count;
        private float _time;

        private void Start()
        {
            Init(_prefab, _count);
        }

        private void Update()
        {
            _time += Time.deltaTime;

            if (TryGetPipe(out var pipe) == false || _time < _delay)
                return;
                
            _time = 0;

            var position = transform.position;
            var spawnYPosition = Random.Range(_minSpawnYPosition, _maxSpawnYPosition);
            var spawnPoint = new Vector3(position.x, spawnYPosition, position.z);
                    
            pipe.transform.position = spawnPoint;
            pipe.gameObject.SetActive(true);
            
            DisablePipe();
        }

        public void Init(float delay, int count, Pipe prefab)
        {
            _delay = delay;
            _count = count;
            _prefab = prefab;
        }
    }
}
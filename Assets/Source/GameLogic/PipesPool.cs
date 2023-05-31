using System.Collections.Generic;
using System.Linq;
using Infrastructure;
using UnityEngine;

namespace GameLogic
{
    public abstract class PipesPool : MonoBehaviour
    {
        [SerializeField] private Camera _camera;

        private readonly List<Pipe> _pool = new();
        
        protected void Init(Pipe pipe, int count)
        {
            for (var i = 0; i < count; i++)
            {
                var newPipe = Instantiate(pipe, null);
                newPipe.gameObject.SetActive(false);

                _pool.Add(newPipe);
            }
        }

        protected void DisablePipe()
        {
            const float DisableXPosition = -1f;
            
            foreach (var pipe in from pipe in _pool
                     where pipe.gameObject.activeSelf
                     let point = _camera.WorldToViewportPoint(pipe.transform.position)
                     where point.x < DisableXPosition
                     select pipe)
            {
                pipe.gameObject.SetActive(false);
            }
        }

        protected bool TryGetPipe(out Pipe pipe)
        {
            pipe = _pool.FirstOrDefault(result => result.gameObject.activeSelf == false);

            return pipe != null;
        }
    }
}

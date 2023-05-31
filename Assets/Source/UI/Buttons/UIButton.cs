using UnityEngine;
using UnityEngine.UI;

namespace UI.Buttons
{
    [RequireComponent(typeof(Button))]
    public abstract class UIButton : MonoBehaviour
    {
        protected Button Button { get; private set; }

        private void Awake()
        {
            Button = GetComponent<Button>();
        }

        protected virtual void OnEnable()
        {
            Button.onClick.AddListener(OnClick);
        }

        protected virtual void OnDisable()
        {
            Button.onClick.RemoveListener(OnClick);
        }

        protected abstract void OnClick();
    }
}
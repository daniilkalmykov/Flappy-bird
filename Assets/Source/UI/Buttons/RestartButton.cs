using Constants;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI.Buttons
{
    public sealed class RestartButton : UIButton
    {
        protected override void OnClick()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(ScenesNames.Level);
        }
    }
}
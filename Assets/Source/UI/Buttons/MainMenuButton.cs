using Constants;
using UnityEngine.SceneManagement;

namespace UI.Buttons
{
    public sealed class MainMenuButton : UIButton
    {
        protected override void OnClick()
        {
            SceneManager.LoadScene(ScenesNames.MainMenu);
        }
    }
}
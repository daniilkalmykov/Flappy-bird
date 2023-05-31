using UnityEngine;

namespace UI.Buttons
{
    public sealed class PlaySoundButton : UIButton
    {
        [SerializeField] private AudioSource _audioSource;
        
        protected override void OnClick()
        {
            _audioSource.Play();
        }
    }
}
using GameLogic;
using TMPro;
using UnityEngine;

namespace UI.Buttons
{
    public sealed class MuteSoundButton : UIButton
    {
        private const string MuteText = "Mute";
        private const string UnmuteText = "Unmute";

        [SerializeField] private TMP_Text _text;
        
        private bool _isMuted;

        private void Start()
        {
            _isMuted = SoundMuter.IsMuted;

            _text.text = _isMuted ? UnmuteText : MuteText;
        }

        protected override void OnClick()
        {
            if (_isMuted)
                Unmute();
            else
                Mute();
        }

        private void Mute()
        {
            SoundMuter.Mute();
            
            _text.text = UnmuteText;
            _isMuted = true;
        }

        private void Unmute()
        {
            SoundMuter.Unmute();
            
            _text.text = MuteText;
            _isMuted = false;
        }
    }
}
using UnityEngine;

namespace GameLogic
{
    public sealed class SoundMuter : MonoBehaviour
    {
        public static bool IsMuted { get; private set; }

        private void Awake()
        {
            IsMuted = GameProgressSaver.GetMuteState();

            if (IsMuted)
                Mute();
            else
                Unmute();
        }

        public static void Mute()
        {
            IsMuted = true;
            AudioListener.volume = IsMuted ? 0f : 1f;

            GameProgressSaver.SetMuteState(IsMuted);
        }

        public static void Unmute()
        {
            IsMuted = false;
            AudioListener.volume = IsMuted ? 0f : 1f;

            GameProgressSaver.SetMuteState(IsMuted);
        }
    }
}
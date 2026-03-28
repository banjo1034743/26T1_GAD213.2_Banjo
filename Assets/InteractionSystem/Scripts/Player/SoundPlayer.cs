using UnityEngine;
using UnityEngine.Audio;

namespace GAD213.P2.InteractionSystem
{
    /// <summary>
    /// This is the base class the all SoundPlayer scripts inherit from
    /// </summary>
    [RequireComponent(typeof(AudioSource))]
    public class SoundPlayer : MonoBehaviour
    {
        #region Variables

        [Header("Sound Playing")]

        [SerializeField] protected AudioClip[] _soundEffects;

        [SerializeField] protected AudioSource _audioSource;

        [SerializeField] protected AudioMixerGroup _audioMixerGroup;

        [SerializeField] protected GameObject _instantiatedAudioSource;

        // === SFX Index Numbers ===

        private const int _attackWeakLowSFX = 0;

        #endregion

        #region Methods

        public void PlaySFX(int soundEffectIndex)
        {

        }

        public void PlaySFXAtPosition(int soundEffectIndex, Vector3 positionToPlay)
        {

        }

        public void PlaySFXClipAt(string soundEffect, Vector3 pos, float volume)
        {
            Debug.Log("We're playing a SFX");

            // Ransaked code
            AudioSource aSource = Instantiate(_instantiatedAudioSource).GetComponent<AudioSource>();
            aSource.gameObject.transform.position = pos;
            aSource.clip = GetSFX(soundEffect);
            aSource.volume = volume;

            aSource.PlayOneShot(aSource.clip);
            Destroy(aSource.gameObject, aSource.clip.length);
        }

        private AudioClip GetSFX(string attack)
        {
            switch (attack)
            {
                case "Attack Weak Low":
                    return _soundEffects[_attackWeakLowSFX];
                default:
                    return _soundEffects[0];
            }
        }

        #endregion
    }
}

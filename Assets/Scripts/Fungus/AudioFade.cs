using GDLJam.Enum;
using DG.Tweening;
using UnityEngine;
using Fungus;

namespace GDLJam.Fungus
{
    [CommandInfo("GDLJam / Audio", nameof(AudioFade), null)]
    public class AudioFade : Command
    {
        [SerializeField] private Source _source;
        [SerializeField] private AudioClip _clip;
        [SerializeField] private AudioSource _audio;
        [SerializeField] private bool _waitForEnd = false;
        [SerializeField] private float _duration;
        [SerializeField] private StateAudioFade _state;

        public override void OnEnter()
        {
            base.OnEnter();
            _audio.clip = _clip;
            _audio.Play();
            if (_state == StateAudioFade.Play) _audio.DOFade(_source.Music, _duration).OnComplete(DOContinue);
            else _audio.DOFade(0, _duration).OnComplete(DOContinue);
            if (!_waitForEnd) Continue();
        }

        private void DOContinue()
        {
            if (_waitForEnd) Continue();
        }
    }
}
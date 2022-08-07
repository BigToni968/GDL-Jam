using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace GDLJam.View
{
    public class Setting : MonoBehaviour
    {
        [SerializeField] private Source _source;
        [SerializeField] private List<AudioSource> _audios;
        [SerializeField] private List<Slider> _sliders;

        private void Awake()
        {
            _audios[0].volume = _sliders[0].value = _source.Music;
            _audios[1].volume = _sliders[1].value = _source.Sound;
        }

        public void SetVoluneMusic(float val) => _audios[0].volume = _source.Music = val;
        public void SetVoluneSound(float val) => _audios[1].volume = _source.Sound = val;
    }
}
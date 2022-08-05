using UnityEngine.UI;
using GDLJam.Enum;
using DG.Tweening;
using UnityEngine;
using Fungus;

namespace GDLJam.Fungus
{
    [CommandInfo("GDLJam / GUI ", "FadeImage", null)]
    public class UIImage : Command
    {
        [SerializeField] private Image _image;
        [SerializeField] private float _time;
        [SerializeField] private bool _waitForEnd = false;
        [SerializeField] private StateImage _state;

        private float _endValue = 0;

        public override void OnEnter()
        {
            base.OnEnter();
            _endValue = System.Convert.ToSingle(_state == StateImage.Visible);
            if (_waitForEnd) _image.DOFade(_endValue, _time).OnComplete(Continue);
            else
            {
                _image.DOFade(_endValue, _time);
                Continue();
            }
        }
    }
}
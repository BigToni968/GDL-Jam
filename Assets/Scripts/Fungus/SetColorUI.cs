using UnityEngine.UI;
using DG.Tweening;
using UnityEngine;
using Fungus;

namespace GDLJam.Fungus
{
    [CommandInfo("GDLJam / Graphics", nameof(SetColorUI), null)]
    public class SetColorUI : Command
    {
        [SerializeField] private Image _ui;
        [SerializeField] private Color _color;
        [SerializeField] private bool _waitForEnd = false;
        [SerializeField] private float _duretion;

        public override void OnEnter()
        {
            base.OnEnter();
            _ui.DOColor(_color, _duretion).OnComplete(DOContinue);
            if (!_waitForEnd) Continue();
        }

        private void DOContinue()
        {
            if (_waitForEnd) Continue();
        }
    }
}
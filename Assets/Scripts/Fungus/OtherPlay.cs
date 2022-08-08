using UnityEngine;
using Fungus;

namespace GDLJam.Fungus
{
    [CommandInfo("GDLJam / Scripting", nameof(OtherPlay), null)]
    public class OtherPlay : Command
    {
        [SerializeField] private Other _other;
        [SerializeField] private bool _play;
        [SerializeField] private bool _shadowPlay;
        [SerializeField] private bool _revers = false;
        [SerializeField] private float _distanceBetween;
        public override void OnEnter()
        {
            base.OnEnter();
            _other.Play = _play;
            _other.PlayShadow = _shadowPlay;
            _other.Revers = _revers;
            _other.DistanceBetween = _distanceBetween;
            Continue();
        }
    }
}
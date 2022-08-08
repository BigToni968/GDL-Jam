using UnityEngine;
using Fungus;

namespace GDLJam.Fungus
{
    [CommandInfo("GDLJam / Scripting", nameof(RotateSprite), null)]

    public class RotateSprite : Command
    {
        [SerializeField] private SpriteRenderer _sprite;

        public override void OnEnter()
        {
            base.OnEnter();
            Vector3 scale = _sprite.transform.localScale;
            scale.x *= -1;
            _sprite.transform.localScale = scale;
            Continue();
        }
    }
}
using UnityEngine;

namespace ColoringEverething
{
    public class SwitchStateObject : MonoBehaviour
    {
        [SerializeField] private Canvas _gameObject;

        public void Switch() => _gameObject.enabled = !_gameObject.enabled;
    }
}
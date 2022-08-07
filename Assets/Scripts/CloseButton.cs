using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    [SerializeField] private List<Canvas> _windowsClosed;

    public void Close() => _windowsClosed.ForEach((x) => x.enabled = false);
}

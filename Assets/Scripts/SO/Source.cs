using UnityEngine;

[CreateAssetMenu(menuName = "GDLjam/Data", fileName = nameof(Source))]
public class Source : ScriptableObject
{
    [SerializeField] private float _music = .5f;
    [SerializeField] private float _sound = .5f;

    private float _musicValue;
    private float _soundValue;

    public float Music { get => _musicValue; set => _musicValue = value; }
    public float Sound { get => _soundValue; set => _soundValue = value; }

    private void OnEnable()
    {
        Music = _music;
        Sound = _sound;
    }
}

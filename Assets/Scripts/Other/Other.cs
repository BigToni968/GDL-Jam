using UnityEngine;

public class Other : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _player;
    [SerializeField] private Transform _lantern;
    [SerializeField] private float _distance;
    [SerializeField] private float _speedMove;
    [SerializeField] private bool _play;
    [SerializeField] private bool _revers;

    [Header("Shadow setting")]
    [SerializeField] private Transform _shadow;
    [SerializeField] private float _distanceBetween;
    [SerializeField] private float _speedShadow;
    [SerializeField] private bool _shadowPlay;

    public bool Play { get => _play; set => _play = value; }
    public bool PlayShadow { get => _shadowPlay; set => _shadowPlay = value; }
    public float DistanceBetween { get => _distanceBetween; set => _distanceBetween = value; }
    public bool Revers { get => _revers; set => _revers = value; }

    private float end, start;
    private float width, height;

    private void Awake()
    {
        (width, height) = _camera.Rectangle();
        start = _camera.transform.position.x + width + _distance;
        end = _camera.transform.position.x - width - _distance;
        SetPosX(ref _lantern, start);
        SetPosX(ref _shadow, start);
    }

    private void SetPosX(ref Transform transform, float val)
    {
        Vector2 pos = transform.position;
        pos.x = val;
        transform.position = pos;
    }

    private void Update()
    {
        if (Play)
        {
            if (!Revers)
            {
                if (_lantern.position.x < end) SetPosX(ref _lantern, start);
                SetPosX(ref _lantern, _lantern.position.x - _speedMove * Time.deltaTime);
            }
            else
            {
                if (_lantern.position.x > start) SetPosX(ref _lantern, end);
                SetPosX(ref _lantern, _lantern.position.x + _speedMove * Time.deltaTime);
            }
        }

        if (PlayShadow)
        {
            if (!Revers)
            {
                if (Vector2.Distance(_player.position, _shadow.position) >= _distanceBetween)
                    SetPosX(ref _shadow, _shadow.position.x - _speedShadow * Time.deltaTime);
            }
            else
            {
                if (Vector2.Distance(_player.position, _shadow.position) <= _distanceBetween)
                    SetPosX(ref _shadow, _shadow.position.x + _speedShadow * Time.deltaTime);
            }
        }
    }
}

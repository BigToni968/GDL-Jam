using UnityEngine.Video;
using UnityEngine;

public class EndVideo : MonoBehaviour
{
    [SerializeField] private VideoPlayer _video;
    [SerializeField] private SceneExplorer _explorer;

    private void Awake() => _video.loopPointReached += End;

    private void End(VideoPlayer video)
    {
        video.seekCompleted -= End;
        _explorer.Next();
    }
}
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(PlayVideo);
    }

    private void PlayVideo()
    {
        videoPlayer.Play();
    }
}

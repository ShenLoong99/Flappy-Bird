using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class MuteButtonScript : MonoBehaviour
{
    public Sprite muteIcon;
    public Sprite unmuteIcon;
    public Image buttonImage;

    private bool isMuted;

    void Start()
    {
        isMuted = PlayerPrefs.GetInt("Muted", 0) == 1;
        UpdateButtonIcon();
    }

    public void ToggleMute()
    {
        isMuted = !isMuted;
        PlayerPrefs.SetInt("Muted", isMuted ? 1 : 0);
        PlayerPrefs.Save();

        // Tell MusicManager to update audio
        MusicManager manager = FindObjectsByType<MusicManager>(FindObjectsSortMode.None).FirstOrDefault();
        if (manager != null)
            manager.SetMute(isMuted);

        UpdateButtonIcon();
    }

    void UpdateButtonIcon()
    {
        if (buttonImage != null)
            buttonImage.sprite = isMuted ? muteIcon : unmuteIcon;
    }
}

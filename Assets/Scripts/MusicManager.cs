using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private AudioSource menuTheme;
    private bool isMuted = false;

    void Awake()
    {
        // Only one MusicManager in the menu scene
        // You can remove duplicate checks if you guarantee only one exists
        menuTheme = GetComponent<AudioSource>();
    }

    void Start()
    {
        // Load saved mute state (default: 0 = unmuted)
        isMuted = PlayerPrefs.GetInt("Muted", 0) == 1;

        if (menuTheme != null)
        {
            menuTheme.mute = isMuted;
            menuTheme.Play();
        }
    }

    // Only used in menu scene
    public void ToggleMute()
    {
        isMuted = !isMuted;
        if (menuTheme != null)
            menuTheme.mute = isMuted;

        PlayerPrefs.SetInt("Muted", isMuted ? 1 : 0);
        PlayerPrefs.Save();
    }

    public void SetMute(bool mute)
    {
        // Only used in menu, if needed programmatically
        isMuted = mute;
        if (menuTheme != null)
            menuTheme.mute = isMuted;
    }

    public bool IsMuted() => isMuted;
}

using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public float delay = 160f; // Time in seconds before playing the music

    void Start()
    {
        Invoke("PlayMusic", delay);
    }

    void PlayMusic()
    {
        GetComponent<AudioSource>().Play();
    }
}
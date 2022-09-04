using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    private AudioSource audioSource;
    private Image image;
    public Sprite on;
    public Sprite off;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        image = GetComponent<Image>();
    }

    bool playing = true;
    public void Toggle() {
        playing = !playing;
        if(playing){
            audioSource.volume = 1f;
            image.sprite = on;
        }
        else{
            audioSource.volume = 0f;
            image.sprite = off;
        }
    }
}

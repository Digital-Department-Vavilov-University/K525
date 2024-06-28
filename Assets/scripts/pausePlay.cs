using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Sprites;
using UnityEngine.UI;


public class pausePlay : MonoBehaviour
{
    private VideoPlayer player;
    public Button button;
    public Button button1;
    public Button buttonRestart;
    public Sprite startSprite;
    public Sprite stopSprite;
    private float videoSpeed;
    void Start()
    {
        player = GetComponent<VideoPlayer>();
        videoSpeed = 1;
    }
    void Update()
    {
        player.playbackSpeed = videoSpeed;
    }
    public void ChangeStartStop()
    {
        if (player.isPlaying == false)
        {
            player.Play();
            button.image.sprite = stopSprite;
            button1.image.sprite = stopSprite;


        }
        else
        {
            player.Pause();
            button.image.sprite = startSprite;
            button1.image.sprite = startSprite;
        }
    }
    public void SetSpeed(float vol)
    {
        videoSpeed = vol;
    }
    public void restart()
    {
        player.frame = 0;
    }
}

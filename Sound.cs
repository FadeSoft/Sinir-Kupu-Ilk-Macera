using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public GameObject soundControlButton;
    public Sprite audioOffSprite;
    public Sprite audioOnSprite;

    void Start()
    {
        if (AudioListener.pause == true)
        {
            soundControlButton.GetComponent<Image>().sprite = audioOffSprite;
        }
        else
        {
            soundControlButton.GetComponent<Image>().sprite = audioOnSprite;
        }
    }
    public void SoundControl()
    {
        if (AudioListener.pause == true)
        {
            AudioListener.pause = false;
            soundControlButton.GetComponent<Image>().sprite = audioOnSprite;
        } 
        else
        {
            AudioListener.pause = true;
            soundControlButton.GetComponent<Image>().sprite = audioOffSprite;
        }



         

        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    AudioSource Player;
    [SerializeField]
    AudioClip[] Clip;
    [SerializeField]
    List<int> beats = new List<int>();
    [SerializeField]
    int clipNum;
    [SerializeField]
    int beat;


     void Start()
    {
        Player = GetComponent<AudioSource>();
    }

    void Update()
    {   

        
        if (ClickTrack.instance.timer == 0 && ClickTrack.instance.play)
        {
           beat += 1;
           if (beat >= beats.Count)
           {
            beat = 0;
           }

           if(beats[beat] == 1)
           {
            
            Player.PlayOneShot(Clip[clipNum]);
            
           }
           
        }
    }

    public void PlayBeat(int beat)
    {
    switch(beats[beat])
    {
        case 0:
        beats[beat] = 1;
        transform.GetChild(beat).GetComponent<Image>().color = Color.green;
        break;
        case 1:
        beats[beat] = 0;
        transform.GetChild(beat).GetComponent<Image>().color = Color.white;
        break;
    }
    }

    public void PlayOneSample()
    {
      Player.PlayOneShot(Clip[clipNum]);
      clipNum += 1;
      if(clipNum >= Clip.Length)
      {
       clipNum = 0;
      }
    }


    
}

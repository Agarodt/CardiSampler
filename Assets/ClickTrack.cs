using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickTrack : MonoBehaviour
{
    public static ClickTrack instance;
    [SerializeField]
    AudioClip[] Clip;
    [SerializeField]
    int clipNum;
    public float timer;
    public float BPM = 60;
    public bool play;
    Text txt;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        txt = transform.GetChild(0).GetComponent<Text>();
    }

 

    // Update is called once per frame
    void Update()
    {   
        if (play)
        {
        timer += Time.deltaTime;
        }

        if (timer * BPM >= 60)
        {
           timer = 0;
        }

        txt.text = "BPM: " + BPM;
    }

    public void TempoPlus1()
    {
        BPM += 1;
    }

    public void TempoMinus1()
    {
        BPM -= 1;
    }

       public void TempoPlus10()
    {
        BPM += 10;
    }

    public void TempoMinus10()
    {
        BPM -= 10;
    }

    public void Play()
    {
        switch(play)
        {
            case false:
            play = true;
            break;
            case true:
            play = false;
            break;
        }
    }

}

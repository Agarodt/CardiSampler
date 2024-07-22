using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoManager : MonoBehaviour
{
    [SerializeField]
    AudioSource Player;
  
    [SerializeField]
    AudioClip[] Clip;

    void Start()
    {
        Player = GetComponent<AudioSource>();
    }

    public void PlayNote(int note)
    {
        Player.PlayOneShot(Clip[note]);
    }
}
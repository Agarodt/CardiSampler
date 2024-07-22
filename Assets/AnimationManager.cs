using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    Animator anim;
    SpriteRenderer rend;
    public bool isPlaying;
    void Start()
    {
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("animPlay", isPlaying);

    }

    public void PlayAnim()
    {
      isPlaying = true;
      rend.enabled = true;
    }
    public void StopAnim()
    {
      isPlaying = false;
    }
}


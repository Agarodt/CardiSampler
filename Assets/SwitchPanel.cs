using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPanel : MonoBehaviour
{
    [SerializeField]
    GameObject DrumMachine;
    [SerializeField]
    GameObject Bass;
    public bool isBass;
    
    public void SwitchInstrument()
    {
        switch(isBass)
        {
            case false:
            DrumMachine.transform.localScale = Vector3.zero;
            Bass.transform.localScale = Vector3.one;
            isBass = true;
            break;
            case true:
            Bass.transform.localScale = Vector3.zero;
            DrumMachine.transform.localScale = Vector3.one;
            isBass = false;
            break;
        }
    }
    
}

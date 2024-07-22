using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseWindow : MonoBehaviour
{
    [SerializeField]
    GameObject Panel;
    [SerializeField]
    bool isOpen;
    
    public void OpenClose()
    {
        switch(isOpen)
        {
            case false:
            Panel.transform.localScale = Vector3.one;
            isOpen = true;
            break;
            case true:
            Panel.transform.localScale = Vector3.zero;
            isOpen = false;
            break;
        }
    }
}

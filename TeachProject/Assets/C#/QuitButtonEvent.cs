using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButtonEvent : MonoBehaviour
{
    public Floor1MoveEvent _Floor1MoveEvent;
    public Square1MoveEvent _Square1MoveEvent;
    public GameObject PanelObj;
    public void QuitEvent()
    {
        PanelObj.SetActive(true);
        _Floor1MoveEvent.enabled = false;
        _Square1MoveEvent.enabled = false;
        gameObject.SetActive(false);
    }
}

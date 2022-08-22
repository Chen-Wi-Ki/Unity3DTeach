using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonEvent : MonoBehaviour
{
    public Floor1MoveEvent _Floor1MoveEvent;
    public Square1MoveEvent _Square1MoveEvent;
    public GameObject ButtonQuitObj;
    public void StartEvent()
    {
        ButtonQuitObj.SetActive(true);
        _Floor1MoveEvent.RunFlag= true;
        _Square1MoveEvent.enabled=true;
        gameObject.SetActive(false);
    }
}

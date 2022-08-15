using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square2TriggerEvent : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Square1")
        {
            Destroy(gameObject);
        }
    }
}

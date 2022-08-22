using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square2TriggerEvent : MonoBehaviour
{
    Vector3 NewObjLocation;
    public Floor1MoveEvent _Floor1MoveEvent;
    public int Level;
    private void Start()
    {
        Level = 13;
    }

    public void ReStart()
    {
        Level = 12;
        transform.localScale = new Vector3(2/ 1.5f, 2/ 1.5f, transform.localScale.z);
        print("Rest Level to " + Level);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.name == "Square1")
        {
            
            float X = Random.value * 8.4f,
                Y = Random.value * 4f,
                Z = 0;

            if (Random.value < 0.5)
            {
                X = X * -1;
            }

            if (Random.value < 0.5)
            {
                Y = Y * -1;
            }

            while ((Y <= other.gameObject.transform.position.y + 1.5f) && (Y >= other.gameObject.transform.position.y - 1.5f))
            {
                Y = Random.value * 4f;
                if (Random.value < 0.5)
                {
                    Y = Y * -1;
                }
            }
            NewObjLocation = new Vector3(X,Y,Z);
            //Destroy(gameObject);
            transform.localScale = new Vector3(transform.localScale.x / 1.5f, transform.localScale.y / 1.5f, transform.localScale.z);
            transform.position = NewObjLocation;
            Level = Level - 1;
            _Floor1MoveEvent._SerialPort.WriteLine(Level.ToString());
            print(Level.ToString());
        }
    }
}

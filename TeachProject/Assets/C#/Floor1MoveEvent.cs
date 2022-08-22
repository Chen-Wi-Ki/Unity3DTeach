using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System;

public class Floor1MoveEvent : MonoBehaviour
{
    // Start is called before the first frame update
    public SerialPort _SerialPort;
    void Start()
    {
        _SerialPort = new SerialPort("COM11",115200);
        _SerialPort.Open();
        _SerialPort.ReadTimeout = 10;
        _SerialPort.RtsEnable = true;
        _SerialPort.DtrEnable = true;
    }

    // Update is called once per frame
    void Update()
    {
        float TempData;
        /*
        if (Input.GetKey("up"))
        {
            if (transform.position.y <= 3.8)
            {
                transform.position = new Vector3(transform.position.x , transform.position.y + Time.deltaTime * 25, transform.position.z);
            }
        }

        if (Input.GetKey("down"))
        {
            if (transform.position.y >= -4.5)
            {
                transform.position = new Vector3(transform.position.x , transform.position.y - Time.deltaTime * 25, transform.position.z);
            }
        }
        */
        if (_SerialPort.IsOpen)
        {
            try 
            {
                
                TempData=float.Parse( _SerialPort.ReadLine())/1000;
                TempData = ((TempData / 5) * (-6f + 17.5f)) - 17.5f;//mapping 0~5  ->  -6~-17.5
                //print(TempData);
                if (TempData < -15f)//High Filter
                {
                    TempData = -15f;
                }
                transform.position = new Vector3(transform.position.x, TempData, transform.position.z);
            }
            catch (TimeoutException)
            {
                //Debug.Log("overflow!");
            }
        }
        GC.Collect();
    }

    private void OnDisable()
    {
        _SerialPort.Close();
    }
}

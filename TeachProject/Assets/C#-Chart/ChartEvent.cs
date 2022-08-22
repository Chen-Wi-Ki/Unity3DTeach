using ChartAndGraph;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System;

public class ChartEvent : MonoBehaviour
{
    public GraphChart Mychart;
    int Time_x;

    SerialPort _SerialPort;
    // Start is called before the first frame update
    void Start()
    {
        Mychart = gameObject.GetComponent<GraphChart>();
        Mychart.DataSource.ClearCategory("UpEvent");
        Mychart.DataSource.ClearCategory("DownEvent");

        _SerialPort = new SerialPort("COM11", 115200);
        _SerialPort.Open();
        _SerialPort.ReadTimeout = 10;
        _SerialPort.RtsEnable = true;
        _SerialPort.DtrEnable = true;

    }
    float TempData;
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey("up"))
        {
            Mychart.DataSource.AddPointToCategoryRealtime("UpEvent", Time_x,1);
        }
        else
        {
            Mychart.DataSource.AddPointToCategoryRealtime("UpEvent", Time_x, 0);
        }

        if (Input.GetKey("down"))
        {
            Mychart.DataSource.AddPointToCategoryRealtime("DownEvent", Time_x, 1);
        }
        else
        {
            Mychart.DataSource.AddPointToCategoryRealtime("DownEvent", Time_x, 0);
        }
        
        
        if (_SerialPort.IsOpen)
        {
            try
            {
                TempData = float.Parse(_SerialPort.ReadLine()) / 1000;
                TempData = float.Parse(_SerialPort.ReadLine()) / 1000;
                Mychart.DataSource.AddPointToCategoryRealtime("AnalogEvent", Time_x, TempData);
                //print(TempData);
                //GC.Collect();
            }
            catch
            {
                Debug.Log("overflow!");
                //GC.Collect();
            }
        }
        GC.Collect();
        Time_x++;
    }

    private void OnDisable()
    {
        _SerialPort.Close();
    }
}

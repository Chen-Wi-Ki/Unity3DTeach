using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;

public class SerialPortEvent : MonoBehaviour
{
    public SerialPort _SerialPort;
    public bool RunFlag = true;

    void Start()
    {
        _SerialPort = new SerialPort("COM15", 115200);
        _SerialPort.Open();
        _SerialPort.ReadTimeout = 10;
        _SerialPort.RtsEnable = true;
        _SerialPort.DtrEnable = true;
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            int count = _SerialPort.BytesToRead;
            print("count="+ count);
            SByte[] TempData = new SByte[count];
            while (count > 0)
            {
                count--;
                TempData[count]= Convert.ToSByte(_SerialPort.ReadByte());
            }
            //print(TempData);
        }
        catch
        {
            print("error read...");
        }
        GC.Collect();
    }

    private void OnDisable()
    {
        _SerialPort.Close();
        GC.Collect();
    }
}

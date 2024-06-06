using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Game_start : MonoBehaviour
{
    SerialPort serialPort;
    string serialData;
    // Start is called before the first frame update
    void Start()
    {
        serialPort = new SerialPort("COM3", 9600);

        serialPort.Open();
        serialPort.ReadTimeout = 500; // Set the read timeout
    }

    // Update is called once per frame
    void Update()
    {
        if (serialData == "switch")
        {

            SceneManager.LoadScene("Tutorial");

        }

        try
        {
            serialData = serialPort.ReadLine();




        }
        catch (System.Exception)
        {
            // Handle read timeout or other exceptions
        }
    }


    void OnDestroy()
    {
        if (serialPort != null && serialPort.IsOpen)
        {
            serialPort.Close(); // シリアルポートがオープンしている場合にのみクローズする
        }
    }

}

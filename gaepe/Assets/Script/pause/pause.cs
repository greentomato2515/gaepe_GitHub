using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEngine.UI;

public class pause : MonoBehaviour
{
    [SerializeField] private Canvas Pause
        ;

    string serialData;
    public static bool pause_bool = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        serialData = SerialHandler.serialData;
        if (serialData == "switch")
        {
            if (pause_bool)
            {
                pause_bool = false;
                Pause.enabled = false;
                

            }
            else
            {
                pause_bool = true;
                Pause.enabled = true;
                
            }

           

        }
    }
}

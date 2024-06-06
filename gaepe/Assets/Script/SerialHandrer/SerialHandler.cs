using UnityEngine;
using System.IO.Ports;
using UnityEngine.SceneManagement;

public class SerialHandler : MonoBehaviour
{
    public string garbage_answer;
    public static string garbage_category;
    public static int scene = 0;
    public static bool heavy = false;
    public static bool frow_1 = false;


    int current_heavy;
    int before_heavy;

    SerialPort serialPort;
    public static string serialData;

    string rfid_1 = "Card UID: 04 AE 76 F2 07 29 80";
    string rfid_2 = "Card UID: 04 D5 75 F2 07 29 80";
    string rfid_3 = "Card UID: 04 F5 75 F2 07 29 80";
    string rfid_4 = "Card UID: 04 D6 75 F2 07 29 80";
    string rfid_6 = "Card UID: 04 0C 70 F2 1C 23 81";
    string rfid_7 = "Card UID: 04 F6 75 F2 07 29 80";
    string rfid_8 = "Card UID: 04 12 75 F2 07 29 81";
    string rfid_9 = "Card UID: 04 FE 70 F2 1C 23 80";
    string rfid_10 = "Card UID: 04 13 75 F2 07 29 81";
    string rfid_11 = "Card UID: 04 07 76 F2 07 29 81";
    string rfid_12 = "Card UID: 04 F0 70 F2 1C 23 80";
    string rfid_13 = "Card UID: 04 06 76 F2 07 29 81";
    string rfid_14 = "Card UID: 04 EA 76 F2 07 29 80";
    string rfid_15 = "Card UID: 04 E2 70 F2 1C 23 80";
    string rfid_16 = "Card UID: 04 0E 76 F2 07 29 80";
    string rfid_17 = "Card UID: 04 CB 76 F2 07 29 80";
    string rfid_18 = "Card UID: 04 D4 70 F2 1C 23 80";
    string rfid_19 = "Card UID: 04 CA 76 F2 07 29 80";
    string rfid_20 = "Card UID: 04 C6 70 F2 1C 23 80";
    void Start()
    {
        serialPort = new SerialPort("COM3", 9600);
        
        serialPort.Open();
        serialPort.ReadTimeout = 500; // Set the read timeout
    }

    void Update()
    {
        bool play_flow_flag = play_flow.play_flow_flag;
      
        if (serialData == rfid_1)
        {
            frow_1 = true;
            play_flow_flag = false;
            garbage_answer = "rfid_1";
            garbage_category = "pura";
            Debug.Log("rfid_1");
        }
        else if (serialData == rfid_2)
        {
            frow_1 = true;
            play_flow_flag = false;
            garbage_answer = "rfid_2";
            garbage_category = "pura";
            Debug.Log("rfid_2");
        }
        else if (serialData == rfid_3)
        {
            frow_1 = true;
            play_flow_flag = false;
            garbage_answer = "rfid_3";
            garbage_category = "pura";
            Debug.Log("rfid_3");
        }
        else if (serialData == rfid_4)
        {
            frow_1 = true;
            play_flow_flag = false;
            garbage_answer = "rfid_4";
            garbage_category = "pura";
            Debug.Log("rfid_4");
        }
        else if (serialData == rfid_6)
        {
            frow_1 = true;
            play_flow_flag = false;
            garbage_answer = "rfid_6";
            garbage_category = "sigen";
            Debug.Log("rfid_6");
        }
        else if (serialData == rfid_7)
        {
            frow_1 = true;
            play_flow_flag = false;
            garbage_answer = "rfid_7";
            garbage_category = "sigen";
            Debug.Log("rfid_7");
        }
        else if (serialData == rfid_8)
        {
            frow_1 = true;
            play_flow_flag = false;
            garbage_answer = "rfid_8";
            garbage_category = "sigen";
            Debug.Log("rfid_8");
        }
        else if (serialData == rfid_9)
        {
            frow_1 = true;
            play_flow_flag = false;
            garbage_answer = "rfid_9";
            garbage_category = "sigen";
            Debug.Log("rfid_9");
        }
        else if (serialData == rfid_10)
        {
            frow_1 = true;
            play_flow_flag = false;
            garbage_answer = "rfid_10";
            garbage_category = "funen";
            Debug.Log("rfid_10");

        }
        else if (serialData == rfid_11)
        {
            frow_1 = true;
            play_flow_flag = false;
            garbage_answer = "rfid_11";
            garbage_category = "funen";
            Debug.Log("rfid_12");
        }
        else if (serialData == rfid_12)
        {
            frow_1 = true;
            play_flow_flag = false;
            garbage_answer = "rfid_12";
            garbage_category = "funen";
            Debug.Log("rfid_12");
        }
        else if (serialData == rfid_13)
        {
            frow_1 = true;
            play_flow_flag = false;
            garbage_answer = "rfid_13";
            garbage_category = "funen";
            Debug.Log("rfid_13");
        }
        else if (serialData == rfid_14)
        {
            frow_1 = true;
            play_flow_flag = false;
            garbage_answer = "rfid_14";
            garbage_category = "kanen";
            Debug.Log("rfid_14");
        }
        else if (serialData == rfid_15)
        {
            frow_1 = true;
            play_flow_flag = false;
            garbage_answer = "rfid_15";
            garbage_category = "kanen";
            Debug.Log("rfid_15");
        }
        else if (serialData == rfid_16)
        {
            frow_1 = true;
            play_flow_flag = false;
            garbage_answer = "rfid_16";
            garbage_category = "kanen";
            Debug.Log("rfid_16");
        }
        else if (serialData == rfid_17)
        {
            frow_1 = true;
            play_flow_flag = false;
            garbage_answer = "rfid_17";
            garbage_category = "kanen";
            Debug.Log("rfid_17");
        }
        else if (serialData == rfid_18)
        {
            frow_1 = true;
            play_flow_flag = false;
            garbage_answer = "rfid_18";
            garbage_category = "sodai";
            Debug.Log("rfid_18");
        }
        else if (serialData == rfid_19)
        {
            frow_1 = true;
            play_flow_flag = false;
            garbage_answer = "rfid_19";
            garbage_category = "sodai";
            Debug.Log("rfid_19");
        }
        else if(serialData == rfid_20)
        {
            frow_1 = true;
            play_flow_flag = false;
            garbage_answer = "rfid_20";
            garbage_category = "sodai";
            Debug.Log("rfid_20");

        }
        else if(serialData == "switch")
        {
            serialData = "0";
        }
        else if(serialData == "heavy")
        {

            Debug.Log("heavy");
                heavy = true;
                

            
                
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

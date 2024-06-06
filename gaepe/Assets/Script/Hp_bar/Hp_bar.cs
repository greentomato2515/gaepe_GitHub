using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hp_bar : MonoBehaviour
{
   
   
    private SerialHandler answer;
    public static bool check_start;
    string status;
    string g_status;
    string g_category;
    bool play_flow_flag = play_flow.play_flow_flag;
    bool frow_1 = SerialHandler.frow_1;
    bool heavy = SerialHandler.heavy;
    // Start is called before the first frame update
    void Start()
    {
        answer = FindObjectOfType<SerialHandler>(); // Ensure SerialHandler is assigned properly
        if (answer == null)
        {
            Debug.LogError("SerialHandler not found. Make sure it is added to the scene.");
            return;
        }

        status = answer.garbage_answer;
        g_status = time_count.garbage_state; // 静的メンバーにクラス名を使ってアクセス
        g_category = SerialHandler.garbage_category;
       
    }

    // Update is called once per frame
    void Update()
    {
        
        g_status = time_count.garbage_state; // 静的メンバーにクラス名を使ってアクセス
        g_category = SerialHandler.garbage_category;
        Debug.Log(g_status);
        Debug.Log(g_category);
        if (answer == null)
        {
            Debug.LogError("SerialHandler is null. Make sure it is assigned properly.");
            return;
        }

        if (status != answer.garbage_answer)
        {
            Debug.Log("sakkitotigau");
            status = answer.garbage_answer; // statusがrfidデータ

            // 分別の分岐
            if (g_status == g_category)
            {
                check_start = true;
                
                // 正しい分別の場合、HPを減らさないまたは別の処理を行う
                Debug.Log("正しい分別です！");
            }
            else
            {
                // 誤った分別の場合、HPを減らす
                check_start = false;
               
                Debug.Log("誤った分別です！");
            }

            // HPが0以下になった場合の処理
            

            // ゴミの状態を更新
            g_status = time_count.garbage_state; // 静的メンバーにクラス名を使ってアクセス
        }

        // HPの値をログに表示
        

       
    }

    
}

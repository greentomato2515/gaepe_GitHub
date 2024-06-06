using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class tutorial_play : MonoBehaviour
{
    [SerializeField]
    private Canvas finish;
    private SerialHandler answer;
    string status;
    string g_status;
    int scene_number;
    string g_category;
    private string serialData;
    public GameObject tutorial_message = null;
    private Text message; // Textコンポーネントを格納する変数
    public static bool check_start;
    public static string garbage_state;
    private string[] garbageCategories = { "pura", "sigen", "funen", "kanen", "sodai" };
    bool frow_1 = SerialHandler.frow_1;
    bool heavy = SerialHandler.heavy;

    // Start is called before the first frame update
    void Start()
    {
        garbage_random();
        finish.enabled = false;
        answer = FindObjectOfType<SerialHandler>(); // Ensure SerialHandler is assigned properly
        status = answer.garbage_answer;
     
        g_category = SerialHandler.garbage_category;
        
    }

    // Update is called once per frame
    void Update()
    {
        frow_1 = SerialHandler.frow_1;
        heavy = SerialHandler.heavy;
        message = tutorial_message.GetComponent<Text>();
        if (status != answer.garbage_answer)
        {
            Debug.Log("sakkitotigau");
            status = answer.garbage_answer; // statusがrfidデータ

            // 分別の分岐
            if (g_status == g_category)
            {
                check_start = true;
                message.text = "その調子で、ボスを倒してみよう！！";
                // 正しい分別の場合、HPを減らさないまたは別の処理を行う
                Debug.Log("正しい分別です！");
                finish.enabled = true;
               
            }
            else
            {
                check_start = false;
                // 誤った分別の場合、HPを減らす
                message.text = "もう一度探してみよう！";

                Debug.Log("誤った分別です！");
            }
            g_status = time_count.garbage_state; // 静的メンバーにクラス名を使ってアクセス
        }
        serialData = SerialHandler.serialData;
        if (scene_number == 0)
        {
            if (serialData == "switch")
            {
                SceneManager.LoadScene("Game_Play");
            }
        }

        if (frow_1)
        {
            Debug.Log("frow_1");
            if (heavy)
            {
                Debug.Log("heavy");
                if (check_start)
                {
                    scene_number = 0;
                    check_start = false;
                }

            }
        }
    }

    void garbage_random()
    {
        garbage_state = garbageCategories[Random.Range(0, garbageCategories.Length)];
        Debug.Log(garbage_state);
    }
}

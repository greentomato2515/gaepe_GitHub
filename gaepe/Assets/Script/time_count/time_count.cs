using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class time_count : MonoBehaviour
{
    public static string garbage_state;
    private string[] garbageCategories = { "pura", "sigen", "funen", "kanen", "sodai" };
    bool garbage_bool = true;
    float minutes;
    private float elapsedTime = 0f;
 
    bool time;
    // 特定の時間（分と秒）でgarbage_randomを呼び出すためのリスト
    private List<(int minutes, int seconds)> triggerTimes = new List<(int, int)>
    {
        (0,0),
        (0, 30),
        (1, 0),
        (1, 30),
        (2, 0),
        (2, 30)
    };

    private void Start()
    {
       
    }

    void Update()
    {
        if(minutes == 15 | minutes == 45)
        {
            garbage_bool = true;
        }
        time = pause.pause_bool;
        if (time)
        {
            
                elapsedTime += Time.deltaTime;
                UpdateTimerDisplay(elapsedTime);
            
        }
        
    

}

   

    void UpdateTimerDisplay(float timeToDisplay)
    {
        // 分と秒に変換
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliseconds = (timeToDisplay % 1) * 1000;
       
        // 特定の時間にgarbage_randomを呼び出す
        foreach (var triggerTime in triggerTimes)
        {
            if (garbage_bool)
            {
                if (minutes == triggerTime.minutes && seconds == triggerTime.seconds)
                {

                    garbage_random();
                    garbage_bool = false;
                    break; // 一致する時間が見つかったらループを抜ける
                }
            }
            
        }

        // 3分経過時の処理
        if (minutes == 3)
        {
            
          
            SceneManager.LoadScene("Game_over");
        }
        Debug.Log(garbage_state);
        // UIテキストを更
        
    }

    void garbage_random()
    {
        garbage_state = garbageCategories[Random.Range(0, garbageCategories.Length)];
        Debug.Log(garbage_state);
    }
}

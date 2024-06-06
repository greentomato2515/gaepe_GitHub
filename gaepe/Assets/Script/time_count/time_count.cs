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
    // ����̎��ԁi���ƕb�j��garbage_random���Ăяo�����߂̃��X�g
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
        // ���ƕb�ɕϊ�
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliseconds = (timeToDisplay % 1) * 1000;
       
        // ����̎��Ԃ�garbage_random���Ăяo��
        foreach (var triggerTime in triggerTimes)
        {
            if (garbage_bool)
            {
                if (minutes == triggerTime.minutes && seconds == triggerTime.seconds)
                {

                    garbage_random();
                    garbage_bool = false;
                    break; // ��v���鎞�Ԃ����������烋�[�v�𔲂���
                }
            }
            
        }

        // 3���o�ߎ��̏���
        if (minutes == 3)
        {
            
          
            SceneManager.LoadScene("Game_over");
        }
        Debug.Log(garbage_state);
        // UI�e�L�X�g���X
        
    }

    void garbage_random()
    {
        garbage_state = garbageCategories[Random.Range(0, garbageCategories.Length)];
        Debug.Log(garbage_state);
    }
}

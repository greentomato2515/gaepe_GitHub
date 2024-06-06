using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class tutorial_flow : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI message;

    private int tutorial_number = 0;
    private string serialData;


    // Start is called before the first frame update
    void Start()
    {
        
           
            
                Debug.Log("Text component found on tutorial_message.");
                message.text = "始めまして、分別浦島太郎さん。" +
                    "僕の名前は、カメ！" +
                    "実は、このビーチにゴミの魔王が現れて" +
                    "ゴミだらけにされちゃったんだ…" +
                    "このままじゃ僕ここに住めなくなっちゃ！" +
                    "力を貸してくれない？";
            
           
    }

    // Update is called once per frame
    void Update()
    {
        serialData = SerialHandler.serialData;
        Debug.Log("Serial Data: " + serialData); // デバッグ用ログ

        if (serialData == "switch")
        {
            tutorial_number += 1;
            Debug.Log(tutorial_number); // デバッグ用ログ

            if (tutorial_number == 1)
            {
                if (message != null)
                {
                    message.text = "魔王の弱点は、ゴミの分別パワー！" +
                        "魔王のお腹に書かれた分別の種類と同じゴミを、" +
                        "ゴミの分別パワーに抽出できるスペシャルな大砲に入れて、" +
                        "ゴミの魔王を倒そう！" +
                        "制限時間内に魔王を倒せたら君の勝ち!";
                 
                    Debug.Log("Updated message for tutorial number 0."); // デバッグ用ログ
                }
            }
            else if (tutorial_number == 2)
            {
                if (message != null)
                {
                    message.text = "まず、ゴミの魔王にダメージを与えてみよう！" +
                        "魔王のお腹をよ～く見て、同じ分別の種類のゴミを" +
                        "地面に落ちているゴミから探して、大砲の穴の中に入れてみよう！！";
                  
                    Debug.Log("Updated message for tutorial number 1."); // デバッグ用ログ
                }
            }
            if (tutorial_number == 3)
            {
                StartCoroutine(movie_wait());
            }
            if (tutorial_number == 4)
            {
                SceneManager.LoadScene("Tutorial_Play");
            }
        }
    }

    IEnumerator movie_wait()
    {
        // 動画を流す
        yield return new WaitForSeconds(1f);
        if (message != null)
        {
            message.text = "実際にボスに攻撃してみよう！";
            Debug.Log("Updated message after movie wait."); // デバッグ用ログ
        }
        
    }
}

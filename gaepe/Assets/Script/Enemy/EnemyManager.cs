using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] public int hp = 200;
    [SerializeField] private Image hp_bar;
    bool play_flow_flag = play_flow.play_flow_flag;
    bool frow_1 = SerialHandler.frow_1;
    bool heavy = SerialHandler.heavy;
    Rigidbody rigidbody;
    Animator animator;
    bool check_start;
    bool ballet;
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
        UpdateHpBar(); // 初期HPバーの更新
    }

    void Update()
    {
        ballet = PlayerController.ballet;
        check_start = Hp_bar.check_start;
        if (hp <= 0)
        {
            hp = 0;
            Debug.Log("HPがゼロになりました！");
            SceneManager.LoadScene("Game_clear");
            // 必要に応じて追加の処理を行う（ゲームオーバーなど）
        }
    }
    //タグの検知
    public void OnTriggerEnter(Collider other)
    {
        //Bullet(弾が当たった時)タグの処理
        if(other.CompareTag("Bullet"))
        {
            if (check_start)
            {
                animator.SetTrigger("Damage");
                hp -= 50;
                UpdateHpBar();
                check_start = false;
            }
            
        }
    }

    
    void UpdateHpBar()
    {
        frow_1 = false;
        heavy = false;
        ballet = false;
        play_flow_flag = true;
        if (hp_bar != null)
        {
            hp_bar.fillAmount = (float)hp / 200f; // HPバーの表示を更新
        }
        else
        {
            Debug.LogError("HP bar Image is not assigned.");
        }
    }
}

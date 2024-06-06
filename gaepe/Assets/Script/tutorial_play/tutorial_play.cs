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
    private Text message; // Text�R���|�[�l���g���i�[����ϐ�
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
            status = answer.garbage_answer; // status��rfid�f�[�^

            // ���ʂ̕���
            if (g_status == g_category)
            {
                check_start = true;
                message.text = "���̒��q�ŁA�{�X��|���Ă݂悤�I�I";
                // ���������ʂ̏ꍇ�AHP�����炳�Ȃ��܂��͕ʂ̏������s��
                Debug.Log("���������ʂł��I");
                finish.enabled = true;
               
            }
            else
            {
                check_start = false;
                // ��������ʂ̏ꍇ�AHP�����炷
                message.text = "������x�T���Ă݂悤�I";

                Debug.Log("��������ʂł��I");
            }
            g_status = time_count.garbage_state; // �ÓI�����o�[�ɃN���X�����g���ăA�N�Z�X
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

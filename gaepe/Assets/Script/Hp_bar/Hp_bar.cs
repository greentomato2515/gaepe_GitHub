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
        g_status = time_count.garbage_state; // �ÓI�����o�[�ɃN���X�����g���ăA�N�Z�X
        g_category = SerialHandler.garbage_category;
       
    }

    // Update is called once per frame
    void Update()
    {
        
        g_status = time_count.garbage_state; // �ÓI�����o�[�ɃN���X�����g���ăA�N�Z�X
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
            status = answer.garbage_answer; // status��rfid�f�[�^

            // ���ʂ̕���
            if (g_status == g_category)
            {
                check_start = true;
                
                // ���������ʂ̏ꍇ�AHP�����炳�Ȃ��܂��͕ʂ̏������s��
                Debug.Log("���������ʂł��I");
            }
            else
            {
                // ��������ʂ̏ꍇ�AHP�����炷
                check_start = false;
               
                Debug.Log("��������ʂł��I");
            }

            // HP��0�ȉ��ɂȂ����ꍇ�̏���
            

            // �S�~�̏�Ԃ��X�V
            g_status = time_count.garbage_state; // �ÓI�����o�[�ɃN���X�����g���ăA�N�Z�X
        }

        // HP�̒l�����O�ɕ\��
        

       
    }

    
}

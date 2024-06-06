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
                message.text = "�n�߂܂��āA���ʉY�����Y����B" +
                    "�l�̖��O�́A�J���I" +
                    "���́A���̃r�[�`�ɃS�~�̖����������" +
                    "�S�~���炯�ɂ��ꂿ������񂾁c" +
                    "���̂܂܂���l�����ɏZ�߂Ȃ��Ȃ�����I" +
                    "�͂�݂��Ă���Ȃ��H";
            
           
    }

    // Update is called once per frame
    void Update()
    {
        serialData = SerialHandler.serialData;
        Debug.Log("Serial Data: " + serialData); // �f�o�b�O�p���O

        if (serialData == "switch")
        {
            tutorial_number += 1;
            Debug.Log(tutorial_number); // �f�o�b�O�p���O

            if (tutorial_number == 1)
            {
                if (message != null)
                {
                    message.text = "�����̎�_�́A�S�~�̕��ʃp���[�I" +
                        "�����̂����ɏ����ꂽ���ʂ̎�ނƓ����S�~���A" +
                        "�S�~�̕��ʃp���[�ɒ��o�ł���X�y�V�����ȑ�C�ɓ���āA" +
                        "�S�~�̖�����|�����I" +
                        "�������ԓ��ɖ�����|������N�̏���!";
                 
                    Debug.Log("Updated message for tutorial number 0."); // �f�o�b�O�p���O
                }
            }
            else if (tutorial_number == 2)
            {
                if (message != null)
                {
                    message.text = "�܂��A�S�~�̖����Ƀ_���[�W��^���Ă݂悤�I" +
                        "�����̂�������`�����āA�������ʂ̎�ނ̃S�~��" +
                        "�n�ʂɗ����Ă���S�~����T���āA��C�̌��̒��ɓ���Ă݂悤�I�I";
                  
                    Debug.Log("Updated message for tutorial number 1."); // �f�o�b�O�p���O
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
        // ����𗬂�
        yield return new WaitForSeconds(1f);
        if (message != null)
        {
            message.text = "���ۂɃ{�X�ɍU�����Ă݂悤�I";
            Debug.Log("Updated message after movie wait."); // �f�o�b�O�p���O
        }
        
    }
}

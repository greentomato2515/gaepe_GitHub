using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class play_flow : MonoBehaviour
{
    
    public static bool play_flow_flag = true;
    [SerializeField] public TextMeshProUGUI play_flow_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (play_flow_flag)
        {
            play_flow_text.text = "�S�~����������A�V�[����ǂݎ����ɂ������ĂˁI";
        }
        else
        {
            play_flow_text.text = "�Ō�ɃS�~�����̒��Ɏ̂ĂĂˁI";
        }
    }
}

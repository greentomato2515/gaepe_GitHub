using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static bool ballet = true;
    [SerializeField] GameObject bulletPrefab;//bulletPrefabを取得
    bool frow_1 = SerialHandler.frow_1;
    bool heavy = SerialHandler.heavy;
    void Update()
    {
        frow_1 = SerialHandler.frow_1;
        heavy = SerialHandler.heavy;
        OnclickSpacekey();
    }


    //Spaceキーを押したら弾を取得、生成
    public void OnclickSpacekey()
    {
        if(frow_1)

        {
            Debug.Log("flow_1");
            if (heavy)
            {

                Debug.Log("heavy");
                if (ballet)
                {
                    Vector3 pos = transform.position;

                    pos.y += 1;

                    Instantiate(bulletPrefab, pos, Quaternion.Euler(0, 0, 0));
                    frow_1 = false;
                    heavy = false;
                    ballet = false;
                }
                
            }
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    private float speed = 0.03f;//大砲のスピード取得

    void Update()
    {
        shot();
    }

    //大砲の速度処理
    private void shot()
    {
        transform.position += transform.forward * speed;
        Destroy(this.gameObject , 2.5f);
    }
}

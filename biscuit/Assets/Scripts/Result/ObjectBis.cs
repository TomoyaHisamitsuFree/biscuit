using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBis : MonoBehaviour
{
    private Vector3 pos;    // 位置
    private Vector3 rot;    // 位置

    //======================================
    //  初期化処理
    //======================================
    void Start()
    {

    }

    //======================================
    //  更新処理
    //======================================
    void Update()
    {
        int nRand = Random.Range(-10,10);
        float fRand = nRand * 1.0f;

        //位置を取得する  
        pos = transform.position;

        //下に落下させる
        pos.y -= 0.05f;

        //位置を設定する
        transform.position = pos;

        //位置を取得する  
        rot = transform.eulerAngles;

        //下に落下させる
        rot.y += fRand * 0.5f;
        rot.x += fRand;

        //位置を設定する
        transform.eulerAngles = rot;
    }

    //======================================
    //  画面外に出た時削除する処理
    //======================================
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

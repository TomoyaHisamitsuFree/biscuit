using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class BisMountain : MonoBehaviour
{
    public Vector3 Pos;
    private float Max;

     //======================================
     //  初期化処理
     //======================================
     void Start()
    {
        Pos.y = -5;

        //位置を設定する
        transform.position = Pos;

        Max = 500.0f;
    }

    //======================================
    //  更新処理
    //======================================
    void Update()
    {
        if(Pos.y <= Max)
        {
            //位置を取得する  
            Pos = transform.position;

            //下に落下させる
            Pos.y += 0.5f;

            //位置を設定する
            transform.position = Pos;
        }
        else
        {
            //ビスケットを降らせないようにする
            

            //スコアをアクティブにする


        }
    }
}

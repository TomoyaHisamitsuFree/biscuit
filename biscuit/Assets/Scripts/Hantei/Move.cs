using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Transform wkpos;
    Vector2 movepos;

    // Start is called before the first frame update
    void Start()
    {
        //三角の位置を保存
        wkpos = transform;
    }

    // Update is called once per frame
    void Update()
    {
        //右移動
        if(Input.GetKey(KeyCode.D))
        {
            movepos  = wkpos.position;
            movepos.x += 0.1f;
            wkpos.position = movepos;
        }

        //左移動
        if(Input.GetKey(KeyCode.A))
        {
            movepos  = wkpos.position;
            movepos.x -= 0.1f;
            wkpos.position = movepos;

        }

    }
}

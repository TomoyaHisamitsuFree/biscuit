using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitileButton : MonoBehaviour
{
    private bool bPIKAPIKA;          // 点滅
    private int nPIKAPICount;        // 点滅用のカウント

    //======================================
    //  初期化処理
    //======================================
    void Start()
    {
        bPIKAPIKA = false;
        nPIKAPICount = 0;
        StartCoroutine(ColorChange());
    }

    //======================================
    //  更新処理
    //======================================
    void Update()
    {
        if (bPIKAPIKA == true)
        {
            if (GetComponent<SpriteRenderer>().material.color != Color.gray)
            {
                GetComponent<SpriteRenderer>().material.color = Color.gray;
            }
        }
        else
        {
            if (GetComponent<SpriteRenderer>().material.color != Color.white)
            {
                GetComponent<SpriteRenderer>().material.color = Color.white;
            }
        }
    }

    public IEnumerator ColorChange()
    {
        while(true)
        {
            yield return new WaitForSeconds(1.0f);
            bPIKAPIKA = true;
            yield return new WaitForSeconds(1.0f);
            bPIKAPIKA = false;
        }
    }
}

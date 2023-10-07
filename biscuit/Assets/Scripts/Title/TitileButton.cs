using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitileButton : MonoBehaviour
{
    private bool bPIKAPIKA;          // �_��
    private int nPIKAPICount;        // �_�ŗp�̃J�E���g

    //======================================
    //  ����������
    //======================================
    void Start()
    {
        bPIKAPIKA = false;
        nPIKAPICount = 0;
        StartCoroutine(ColorChange());
    }

    //======================================
    //  �X�V����
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class BisMountain : MonoBehaviour
{
    public Vector3 Pos;
    private float Max;

     //======================================
     //  ����������
     //======================================
     void Start()
    {
        Pos.y = -5;

        //�ʒu��ݒ肷��
        transform.position = Pos;

        Max = 500.0f;
    }

    //======================================
    //  �X�V����
    //======================================
    void Update()
    {
        if(Pos.y <= Max)
        {
            //�ʒu���擾����  
            Pos = transform.position;

            //���ɗ���������
            Pos.y += 0.5f;

            //�ʒu��ݒ肷��
            transform.position = Pos;
        }
        else
        {
            //�r�X�P�b�g���~�点�Ȃ��悤�ɂ���
            

            //�X�R�A���A�N�e�B�u�ɂ���


        }
    }
}

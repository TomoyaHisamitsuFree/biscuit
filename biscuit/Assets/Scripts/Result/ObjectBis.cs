using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBis : MonoBehaviour
{
    private Vector3 pos;    // �ʒu
    private Vector3 rot;    // �ʒu

    //======================================
    //  ����������
    //======================================
    void Start()
    {

    }

    //======================================
    //  �X�V����
    //======================================
    void Update()
    {
        int nRand = Random.Range(-10,10);
        float fRand = nRand * 1.0f;

        //�ʒu���擾����  
        pos = transform.position;

        //���ɗ���������
        pos.y -= 0.05f;

        //�ʒu��ݒ肷��
        transform.position = pos;

        //�ʒu���擾����  
        rot = transform.eulerAngles;

        //���ɗ���������
        rot.y += fRand * 0.5f;
        rot.x += fRand;

        //�ʒu��ݒ肷��
        transform.eulerAngles = rot;
    }

    //======================================
    //  ��ʊO�ɏo�����폜���鏈��
    //======================================
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

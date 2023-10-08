using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPose : MonoBehaviour
{
    public Sprite Default;
    public Sprite A;
    public Sprite S;
    public Sprite D;
    public Sprite F;
    public Sprite AS;
    public Sprite AD;
    public Sprite AF;
    public Sprite SD;
    public Sprite SF;
    public Sprite DF;
    private Image image;

    //======================================
    //  ����������
    //======================================
    void Start()
    {
        // SpriteRenderer�R���|�[�l���g���擾���܂�
        image = GetComponent<Image>();

        //�\������
        image.color = Color.white;

        // �摜��؂�ւ��܂�
        image.sprite = Default;
    }

    //======================================
    //  �X�V����
    //======================================
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            // �摜��؂�ւ��܂�
            image.sprite = A;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            // �摜��؂�ւ��܂�
            image.sprite = S;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            // �摜��؂�ւ��܂�
            image.sprite = D;
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            // �摜��؂�ւ��܂�
            image.sprite = F;
        }

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            // �摜��؂�ւ��܂�
            image.sprite = AD;
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {
            // �摜��؂�ւ��܂�
            image.sprite = AS;
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.F))
        {
            // �摜��؂�ւ��܂�
            image.sprite = AF;
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            // �摜��؂�ւ��܂�
            image.sprite = SD;
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.F))
        {
            // �摜��؂�ւ��܂�
            image.sprite = SF;
        }
        if (Input.GetKey(KeyCode.F) && Input.GetKey(KeyCode.D))
        {
            // �摜��؂�ւ��܂�
            image.sprite = DF;
        }
    }
}

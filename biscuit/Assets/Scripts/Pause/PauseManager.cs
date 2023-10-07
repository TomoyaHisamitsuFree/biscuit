using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField]
    private GameObject BackGame;    // �ʒu

    [SerializeField]
    private GameObject BackTitle;    // �ʒu

    [SerializeField]
    private GameObject Retry;    // �ʒu

    private int nSelect;    // �I��
    private const int SelectMax = 3;

    //======================================
    //  ����������
    //======================================
    void Start()
    {
        nSelect = 0;
    }

    //======================================
    //  �X�V����
    //======================================
    void Update()
    {
        //�I������
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            nSelect++;
            if (nSelect >= SelectMax)
            {
                nSelect = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            nSelect--;
            if (nSelect < 0)
            {
                nSelect = SelectMax - 1;
            }
        }

        //���菈��
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (nSelect == 0)
            {
                // �|�[�Y���A�N�e�B�u�ɂ���
            }
            else if (nSelect == 1)
            {
                // �^�C�g���ɖ߂�
                SceneManager.LoadScene("TitleScene");
            }
            else if (nSelect == 2)
            {
                // �Q�[�������g���C����
                SceneManager.LoadScene("SampleScene");
            }
        }

        //�I�����̃J���[�ύX
        if (nSelect == 0)
        {
            BackGame.GetComponent<SpriteRenderer>().material.color = Color.white;
        }
        else
        {
            BackGame.GetComponent<SpriteRenderer>().material.color = Color.gray;
        }

        if (nSelect == 1)
        {
            BackTitle.GetComponent<SpriteRenderer>().material.color = Color.white;
        }
        else
        {
            BackTitle.GetComponent<SpriteRenderer>().material.color = Color.gray;
        }

        if (nSelect == 2)
        {
            Retry.GetComponent<SpriteRenderer>().material.color = Color.white;
        }
        else
        {
            Retry.GetComponent<SpriteRenderer>().material.color = Color.gray;
        }
    }
}

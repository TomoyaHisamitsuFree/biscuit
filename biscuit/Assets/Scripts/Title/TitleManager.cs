using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // Enter�L�[�i�O���ړ��j�L�[����
        if (Input.GetKey(KeyCode.Return))
        {
            // �����ꂽ��
            SceneManager.LoadScene("SampleScene");
        }
    }
}
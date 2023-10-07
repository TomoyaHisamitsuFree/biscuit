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
        // Enterキー（前方移動）キー入力
        if (Input.GetKey(KeyCode.Return))
        {
            // 押された時
            SceneManager.LoadScene("InGameScene");
        }
    }
}

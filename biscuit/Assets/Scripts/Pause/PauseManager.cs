using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField]
    private GameObject BackGame;    // 位置

    [SerializeField]
    private GameObject BackTitle;    // 位置

    [SerializeField]
    private GameObject Retry;    // 位置

    private int nSelect;    // 選択
    private const int SelectMax = 3;

    //======================================
    //  初期化処理
    //======================================
    void Start()
    {
        nSelect = 0;
    }

    //======================================
    //  更新処理
    //======================================
    void Update()
    {
        //選択処理
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

        //決定処理
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (nSelect == 0)
            {
                // ポーズを非アクティブにする
            }
            else if (nSelect == 1)
            {
                // タイトルに戻る
                SceneManager.LoadScene("TitleScene");
            }
            else if (nSelect == 2)
            {
                // ゲームをリトライする
                SceneManager.LoadScene("SampleScene");
            }
        }

        //選択時のカラー変更
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

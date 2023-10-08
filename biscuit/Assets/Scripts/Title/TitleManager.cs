using Biscuit.InGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource _enterSE = null;

    private bool _isEnd = false;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        _isEnd = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Enterキー（前方移動）キー入力
        if (Input.GetKey(KeyCode.Return))
        {
            if (!_isEnd)
            {
                _isEnd = true;
                StartCoroutine(toToInGame());
            }
        }
    }


    public IEnumerator toToInGame()
    {
        _enterSE?.Play();
        yield return new WaitForSeconds(1.0f);
        // 押された時
        SceneManager.LoadScene("InGameScene");
    }
}

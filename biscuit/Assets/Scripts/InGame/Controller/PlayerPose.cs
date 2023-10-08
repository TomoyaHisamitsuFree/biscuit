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
    //  初期化処理
    //======================================
    void Start()
    {
        // SpriteRendererコンポーネントを取得します
        image = GetComponent<Image>();

        //表示する
        image.color = Color.white;

        // 画像を切り替えます
        image.sprite = Default;
    }

    //======================================
    //  更新処理
    //======================================
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            // 画像を切り替えます
            image.sprite = A;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            // 画像を切り替えます
            image.sprite = S;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            // 画像を切り替えます
            image.sprite = D;
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            // 画像を切り替えます
            image.sprite = F;
        }

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            // 画像を切り替えます
            image.sprite = AD;
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {
            // 画像を切り替えます
            image.sprite = AS;
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.F))
        {
            // 画像を切り替えます
            image.sprite = AF;
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            // 画像を切り替えます
            image.sprite = SD;
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.F))
        {
            // 画像を切り替えます
            image.sprite = SF;
        }
        if (Input.GetKey(KeyCode.F) && Input.GetKey(KeyCode.D))
        {
            // 画像を切り替えます
            image.sprite = DF;
        }
    }
}

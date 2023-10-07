using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEngine;

public class JudgeScript : MonoBehaviour
{
    Vector2 parent;
    public GameObject textB;
    public GameObject textG;
    public GameObject textP;
    GameObject clone;
    Vector2 genPos;
    Vector3 origin;
    Vector3 direction;
    string objTag;
    Ray2D ray;
    int swt = 0;    //swithTextの略。この数値で叩いた時の判定を決める
    // Start is called before the first frame update
    void Start()
    {
        //フレームレート固定
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //親と子の座標取得
        parent = transform.parent.position;
        genPos = transform.position;

        //ノーツを叩いた時の処理
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //取得したオブジェクトの初期化
            objTag = "";

            origin = parent; // 原点
            direction = new Vector3(0, 1,0); // y軸方向を表すベクトル
            ray = new Ray2D(origin, direction); // Rayを生成        	

            //Rayを飛ばす
            RaycastHit2D hit2D = Physics2D.Raycast(ray.origin, ray.direction,10.0f);

            if (hit2D.collider) // もしRayを投射して何らかのコライダーに衝突したら
            {
                objTag = hit2D.collider.gameObject.tag; // 衝突した相手オブジェクトの名前を取得
            }

            //衝突した相手の判定
            if(objTag == "Good")
            {
                swt = 1;    //判定Good
            }
            else if(objTag == "Perfect")
            {
                swt = 2;    //判定Perfect
            }

            //判定の文字を出力する処理
            switch(swt){

                case 1:     //Goodを出力

                    clone = Instantiate(textG,new Vector3(genPos.x,genPos.y,0f),Quaternion.identity);
                    swt = 0;
                    break;

                case 2:     //Perfectを出力

                    clone = Instantiate(textP,new Vector3(genPos.x,genPos.y,0f),Quaternion.identity);
                    swt = 0;
                    break;

                default:    //Badを出力

                    clone = Instantiate(textB,new Vector3(genPos.x,genPos.y,0f),Quaternion.identity);
                    break;
            }
            //出力したオブジェクトに名前をつける
            clone.name = "judegeT";     //これがなくてもプログラムは動くので、いらない場合は消していいかも
        }
        //判定文字の消去
        Delete();
    }

    void Delete()
    {
        Destroy(clone,2.0f);
    }
}

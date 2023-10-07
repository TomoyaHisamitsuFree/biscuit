using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Wキー（前方移動）キー入力
        if (Input.GetKey(KeyCode.W))
        {
            // 押された時
            /*transform.position += 1.0f * transform.up * Time.deltaTime;*/
        }
    }
}

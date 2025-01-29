using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public int nTime;             // タイムを保存している変数
    public int nResetTime;  // 初期化用のタイマー

    // Start is called before the first frame update
    void Start()
    {
        nTime = nResetTime; // タイマーリセット
    }

    // Update is called once per frame
    void Update()
    {
        // タイマーを減らしていく
        nTime--;
    }
}

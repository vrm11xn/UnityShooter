using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour
{
    public float fResultTime;   // クリアしたときのタイム保存用
    private _timeManager tm;

    // Start is called before the first frame update
    void Start()
    {
        fResultTime = tm.fTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Title");
        }
    }

    void GetResultTime(float fTime)
    {
        fResultTime = fTime;    // 引数のタイムを保存
    }
}

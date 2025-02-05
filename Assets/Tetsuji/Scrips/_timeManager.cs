using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class _timeManager : MonoBehaviour
{
    public float fTime;       // タイムを保存している変数
    public float fResetTime;  // 初期化用のタイマー
    public TextMeshProUGUI timeText; // 時間表示用テキスト

    // Start is called before the first frame update
    void Start()
    {
        // タイマーリセット
        fTime = fResetTime;
        timeText.text = "TimeLimit:" + fTime + "sec";

        // タイマーは消さないで
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        // 今のシーンを取得
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "TimeOver")
        {// タイムオーバーシーンだと何もしない
            return;
        }
        else if (scene.name == "ClearScene")
        {// クリアーシーンだとタイマーを取得
         // ヒエラルキーのオブジェクトを取得
            GameObject objTime = GameObject.Find("TimeManager");
            float fTime = objTime.GetComponent<_timeManager>().fTime;

            // ヒエラルキーのオブジェクトを取得
            GameObject objClear = GameObject.Find("GCManager");
            objClear.GetComponent<_GCManager>().fGetedTime = fTime;
            return;
        }
        else if (scene.name == "gameScene")
        {// ゲームシーンだとタイマーカウントする

            if (fTime < 0.0f)
            {// 限界値以下であれば
                fTime = 0.0f;                       // タイマーゼロ
                SceneManager.LoadScene("TimeOver"); // タイムオーバーシーンへ遷移
                Debug.Log("ChangeTimeOver");
                return;                             // ここでしょりを止める
            }

            // タイマーを減らしていく
            fTime -= Time.deltaTime;       
            timeText.text = "TimeLimit:" + fTime.ToString("f1") + "sec";
        }
    }
}

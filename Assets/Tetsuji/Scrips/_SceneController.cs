using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeScene();
        }
    }

    public void NextScene(string nextScene)
    {// 引数に入れられたシーンネームにシーンを遷移する
        Debug.Log("change");
        SceneManager.LoadScene(nextScene);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("gameScene");
    }
}

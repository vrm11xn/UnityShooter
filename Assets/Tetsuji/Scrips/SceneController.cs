using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextScene(string nextScene)
    {// �����ɓ����ꂽ�V�[���l�[���ɃV�[����J�ڂ���
        Debug.Log("change");
        SceneManager.LoadScene(nextScene);
    }
}

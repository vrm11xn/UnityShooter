using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private _timeManager tm;          // �^�C�}�[

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K) == true)
        {
         
            Debug.Log("ChangeResult");
            SceneManager.LoadScene("result");
        }
    }
}

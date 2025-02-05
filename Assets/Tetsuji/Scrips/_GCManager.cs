using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class _GCManager : MonoBehaviour
{
    public float fGetedTime = 0.0f;
    public TextMeshProUGUI timeText;

    // Start is called before the first frame update
    void Start()
    {
        timeText.text = "TimeLimit:" + fGetedTime + "sec";
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = "TimeLimit:" + fGetedTime.ToString("f1") + "sec";

        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Title");
        }
    }
}

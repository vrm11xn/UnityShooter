using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public int nTime;             // �^�C����ۑ����Ă���ϐ�
    public int nResetTime;  // �������p�̃^�C�}�[

    // Start is called before the first frame update
    void Start()
    {
        nTime = nResetTime; // �^�C�}�[���Z�b�g
    }

    // Update is called once per frame
    void Update()
    {
        // �^�C�}�[�����炵�Ă���
        nTime--;
    }
}

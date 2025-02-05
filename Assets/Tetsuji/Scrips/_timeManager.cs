using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class _timeManager : MonoBehaviour
{
    public float fTime;       // �^�C����ۑ����Ă���ϐ�
    public float fResetTime;  // �������p�̃^�C�}�[
    public TextMeshProUGUI timeText; // ���ԕ\���p�e�L�X�g

    // Start is called before the first frame update
    void Start()
    {
        // �^�C�}�[���Z�b�g
        fTime = fResetTime;
        timeText.text = "TimeLimit:" + fTime + "sec";

        // �^�C�}�[�͏����Ȃ���
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        // ���̃V�[�����擾
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "TimeOver")
        {// �^�C���I�[�o�[�V�[�����Ɖ������Ȃ�
            return;
        }
        else if (scene.name == "ClearScene")
        {// �N���A�[�V�[�����ƃ^�C�}�[���擾
         // �q�G�����L�[�̃I�u�W�F�N�g���擾
            GameObject objTime = GameObject.Find("TimeManager");
            float fTime = objTime.GetComponent<_timeManager>().fTime;

            // �q�G�����L�[�̃I�u�W�F�N�g���擾
            GameObject objClear = GameObject.Find("GCManager");
            objClear.GetComponent<_GCManager>().fGetedTime = fTime;
            return;
        }
        else if (scene.name == "gameScene")
        {// �Q�[���V�[�����ƃ^�C�}�[�J�E���g����

            if (fTime < 0.0f)
            {// ���E�l�ȉ��ł����
                fTime = 0.0f;                       // �^�C�}�[�[��
                SceneManager.LoadScene("TimeOver"); // �^�C���I�[�o�[�V�[���֑J��
                Debug.Log("ChangeTimeOver");
                return;                             // �����ł������~�߂�
            }

            // �^�C�}�[�����炵�Ă���
            fTime -= Time.deltaTime;       
            timeText.text = "TimeLimit:" + fTime.ToString("f1") + "sec";
        }
    }
}

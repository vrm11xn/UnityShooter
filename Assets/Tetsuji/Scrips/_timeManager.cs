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
        fTime = fResetTime; // �^�C�}�[���Z�b�g
        timeText.text = "TimeLimit:" + fTime + "sec";

        // �^�C�}�[�͏����Ȃ���
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        // ���̃V�[�����擾
        Scene scene = SceneManager.GetActiveScene();

        if(scene.name == "TimeOver")
        {// �^�C���I�[�o�[�V�[�����Ɖ������Ȃ�
            return;
        }

        if (fTime < 0.0f)
        {// ���E�l�ȉ��ł����
            fTime = 0.0f;                       // �^�C�}�[�[��
            SceneManager.LoadScene("TimeOver"); // �^�C���I�[�o�[�V�[���֑J��
            Debug.Log("ChangeTimeOver");
            return;                             // �����ł������~�߂�
        }

        fTime -= Time.deltaTime;        // �^�C�}�[�����炵�Ă���
        timeText.text = "TimeLimit:" + fTime.ToString("f1") + "sec";

      
    }
}

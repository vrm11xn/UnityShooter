using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;
    public LifeUIManager lifeUIManager; // LifeUIManager�̃C���X�^���X���Q��

    void Start()
    {
        currentHealth = maxHealth;
        lifeUIManager.SetHealth(currentHealth, maxHealth);
    }

    void Update()
    {
        // �L�[�{�[�h���͂ő̗͂����炷�i��F�X�y�[�X�L�[�������Ƒ̗͂�10����j
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10f);
        }
    }

    void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
        lifeUIManager.SetHealth(currentHealth, maxHealth);
    }
}
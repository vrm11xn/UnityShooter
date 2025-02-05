using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;
    public LifeUIManager lifeUIManager; // LifeUIManagerのインスタンスを参照

    void Start()
    {
        currentHealth = maxHealth;
        lifeUIManager.SetHealth(currentHealth, maxHealth);
    }

    void Update()
    {
        // キーボード入力で体力を減らす（例：スペースキーを押すと体力が10減る）
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
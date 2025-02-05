using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeUIManager : MonoBehaviour
{
    private RectTransform bar;

    void Start()
    {
        Transform barTransform = transform.Find("Bar");
        if (barTransform != null)
        {
            bar = barTransform.GetComponent<RectTransform>();
        }
        else
        {
            Debug.LogError("Barオブジェクトが見つかりません。");
        }
    }

    public void SetHealth(float currentHealth, float maxHealth)
    {
        if (bar != null)
        {
            float healthRatio = currentHealth / maxHealth;
            bar.localScale = new Vector3(healthRatio, 1f, 1f);
        }
    }
}
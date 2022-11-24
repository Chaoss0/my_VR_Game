using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    [SerializeField] private Image _healthbarSprite;

    public void UpdateHealthBar(int maxHealth, int currentHealth)
    {

        _healthbarSprite.fillAmount = currentHealth / maxHealth;
    }


}


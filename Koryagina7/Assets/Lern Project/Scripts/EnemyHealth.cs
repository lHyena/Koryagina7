using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public Transform healthBar;
    public Slider healthFill;

    public float currentHealth;
    public float maxhealth;
    public float healthBarYOffest = 2;
    
    
    void Update()
    {
        PositionHealthBar();  
    }

    public void ChangeHealth(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxhealth);

        healthFill.value = currentHealth / maxhealth;
    }

    private void PositionHealthBar()
    {
        Vector3 current = transform.position;

        healthBar.position = new Vector3(current.x,
            current.y + healthBarYOffest, current.z);

        healthBar.LookAt(Camera.main.transform);

    }
}

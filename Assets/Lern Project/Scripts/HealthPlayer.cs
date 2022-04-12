using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    public GUIStyle myHealth;

    public int MaxHealth = 100;
    public int CurHealth;

    public float heathbarLength;

    public bool Visible = true;
   
    void Start()
    {
        CurHealth = MaxHealth;
        heathbarLength = Screen.width / 6;
    }

    public void ApplyDamage(int damage)
    {
        if(CurHealth < 0)
        {
            return;
        }
        CurHealth -= damage;
        if(CurHealth < 0)
        {
            Die(); 
        }
    }

    void Die()
    {
        
    }
    void Update()
    {
        if (MaxHealth < CurHealth) CurHealth = MaxHealth;
        if (CurHealth < 0) CurHealth = 0;
    }

    void OnGUI()
    {
        if (Visible)
        {
            GUI.Box(new Rect(10, 32, heathbarLength, 200), CurHealth + "/" + MaxHealth, myHealth);
        }
    }
}

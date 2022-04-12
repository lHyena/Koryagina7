using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LernProject
{
    public class Boomb : MonoBehaviour
    {
        [SerializeField] private float _damage = 100000f;

        private void OnCollisionEnter(Collision collision) // ����� ���������������
        {

            if (collision.gameObject.TryGetComponent(out ITakeDamage takeDamage)) // ���������� ����������� ���������� � �������������� � ���
            {
                Debug.Log("Hit!");
                takeDamage.Hit(_damage);
            }
        }
    }
}


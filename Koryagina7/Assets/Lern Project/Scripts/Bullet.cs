using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LernProject
{
    public class Bullet : MonoBehaviour
    {
        private Transform _target;
        private float _speed;
        [SerializeField] private float _damage = 3;

        public void Init(Transform target, float lifeTime, float speed)
        {
            _target = target;
            _speed = speed;
            Destroy(gameObject, lifeTime);
        }
                
        void FixedUpdate()
        {
            //transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed); \\ ��������������� ����
            transform.position += transform.forward * _speed * Time.fixedDeltaTime;
        }

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



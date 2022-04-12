using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LernProject
{
    public class BulletJHON : MonoBehaviour
    {
        private Transform _target;
        private float _speed;
        [SerializeField] private float _damage = 3;
        [SerializeField] private float _force = 3; // ����
        private Rigidbody _rigidbody;
        


        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void Init(Transform target, float lifeTime, float speed)
        {
            _target = target;
            _speed = speed;
            Destroy(gameObject, lifeTime);

            _rigidbody.AddForce(transform.forward * _force);// �������� ���� ������ � �����
        }

        //void FixedUpdate()
        //{
        //    //transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed); \\ ��������������� ����
        //    transform.position += transform.forward * _speed * Time.fixedDeltaTime;
        //}

        private void OnCollisionEnter(Collision collision) // ����� ���������������
        {

            if (collision.gameObject.TryGetComponent(out ITakeDamage takeDamage)) // ���������� ����������� ���������� � �������������� � ���
            {
                Debug.Log("Hit!");

                EnemyHealth stats;

                if (stats = collision.collider.GetComponent<EnemyHealth>())
                {
                    stats.ChangeHealth(-5);
                }
                Destroy(gameObject);

                takeDamage.Hit(_damage);
            }
        }
      
        
    }

}


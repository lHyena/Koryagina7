using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LernProject
{
    public class Player : MonoBehaviour
    {
        public GameObject ShieldPrefab;
        public Transform SpawnPosition;
             
        
        private bool _isSpawnShield;
        [HideInInspector] public int level = 1;// HideInInspector �������� ������� ������ � ���������� �� �� � ����� ����


        public float speed = 2f; // �������� ��������, � � ���������� ���������
        private Vector3 _direction; // ����������� ��������
        public float speedRotate = 20f;
        private bool _isSprint;
        [SerializeField] private float _jumpForce = 50f;
        private float _cfSpeed = 1f;
        [SerializeField] private Rigidbody _rb;

        [SerializeField] private Enemy _enemy; // ���������� ����������
        [SerializeField] private GameObject _bulletPrefab;
        [SerializeField] private Transform _spawnPosition;

        [SerializeField] private Animator _anim;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
            _anim = GetComponent<Animator>();
        }
                      

                      
        void Update()
        {
            if (Input.GetMouseButtonDown(1))
                _isSpawnShield = true; //(1) ��������, ������ �� ����� ���, ����� �� ������

            if (Input.GetMouseButtonDown(0))
            {
                Fire();
            }
                         
            _anim.SetBool("IsWalking", _direction != Vector3.zero);
                                             
        }

        private void FixedUpdate() // �������� ����� ������ � FixeUpdate
        {
            _direction.x = Input.GetAxis("Horizontal");// ����������� ������
            _direction.z = Input.GetAxis("Vertical");// ����������� ������
            
            float sprint = (_isSprint) ? 2f : 1f; // ���������� ��������

            _direction = transform.TransformDirection(_direction);//������� �� ��������� ���������� � ����������
            _rb.MovePosition(transform.position + _direction.normalized * speed * sprint * _cfSpeed * Time.fixedDeltaTime); // ����������� ��.����(������)

            Vector3 rotate = new Vector3(0f, Input.GetAxis("Mouse X") * speedRotate * Time.fixedDeltaTime, 0f);
            //_rb.MoveRotation(_rb.rotation * Quaternion.Euler(rotate));

            transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * speedRotate * Time.fixedDeltaTime, 0)); // ��������� ������� ���������

            if (Input.GetKeyDown(KeyCode.Space)) // ������
                GetComponent<Rigidbody>().AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            
            if (_isSpawnShield)
            {
                _isSpawnShield = false;//(3) ��������� ����� �� ��������� ���� �� ������, ���� ��, �� ��� �� ���������
                SpawnShield(); //(2) ������� ���
            }

            //Move(Time.fixedDeltaTime);
                       
        }

        
        private void SpawnShield()
        {
            var shieldObj = Instantiate(ShieldPrefab, SpawnPosition.position, SpawnPosition.rotation);
            var shield = shieldObj.GetComponent<Shield>(); // ������� ������ �� ��������� ������ ( ����)
            shield.Init(10 * level);
            shield.transform.SetParent(SpawnPosition);// ���������� ���������� � �������
        }

        private void Fire() // ����� �������� �� ���������� *
        {
            var enemyObj = Instantiate(_bulletPrefab, _spawnPosition.position, _spawnPosition.rotation);
            var enemy = enemyObj.GetComponent<BulletJHON>(); // ������� ������ �� ��������� ������ (����� )
            enemy.Init(_enemy.transform, 10, 0.6f);

        }

        //private void Move(float delta) // ������ ��������
        //{
        //    var fixedDirection = transform.TransformDirection(_direction.normalized); // ����� ��������� � ��������� ��������
        //    transform.position += fixedDirection * (_isSprint ? speed * 2 : speed) * delta; // delta ����� ��������, ����� �� ���� ������� // transform.position - ������� �������
        //    // normalized ������ ���������� �������� ��� ��� �������� �� �����������, ��� � �� ����������
        //}
    }

}

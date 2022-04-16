using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LernProject
{
    public class Spawner : MonoBehaviour
    {
        public GameObject GhostPrefab;
        public Transform SpawnPosition;
               

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
                SpawnGhost();

        }

        private void SpawnGhost()
        {

            var GhostObj = Instantiate(GhostPrefab, SpawnPosition.position, SpawnPosition.rotation);
            var ghost = GhostObj.GetComponent<Enemy>(); // �������� ������ �� �����


        }

        ///// <summary>
        ///// ������� ������� ����� � � ��������
        ///// </summary>
        //public GameObject Object; // ������ �����������
        //public bool stopSpawning = false; 
        //public float spawnTime; // ����� ��������� �����
        //public float spawnDelay; // ������� � �������� �����

        //void Start()
        //{
        //    InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        //}

        //public void SpawnObject()
        //{
        //    Instantiate(Object, transform.position, transform.rotation);

        //    if (stopSpawning)
        //    {
        //        CancelInvoke("SpawnObject");
        //    }
        //}
    }

}



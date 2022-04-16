using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LernProject
{
    //public sealed class ShieldGenerate : Weapon // sealed - нельз€ унаследоватьс€ 
    //{
    //    private int _level;
    //    public ShieldGenerate(int level, GameObject spawnPrefab, Transform spawnPoint) : base(spawnPrefab, spawnPoint)
    //    {
    //        _level = level;
    //    }

    //    public override GameObject Spawn()
    //    {
    //        var shieldObj = Object.Instantiate(_spawnPrefab, _spawnPoint.position, _spawnPoint.rotation);
    //        var shield = shieldObj.GetComponent<Shield>(); // получем ссылку на экземпл€р класса ( щита)
    //        shield.Init(10 * _level);

    //        shield.transform.SetParent(_spawnPoint);// посто€нное нахождение с игроком
    //        return shieldObj;
    //    }
    //}

}



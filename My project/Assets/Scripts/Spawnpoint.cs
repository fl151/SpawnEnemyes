using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    public void SpawnEnemy(Enemy prefab)
    {
        Instantiate(prefab, gameObject.transform);
    }
}

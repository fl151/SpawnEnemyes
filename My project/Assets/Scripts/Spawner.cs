using System.Collections;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;

    private float _timeDelayInSeconds;
    private bool _isWorking;
    private Spawnpoint[] _spawnpoints;

    private void Awake()
    {
        _isWorking = true;

        _timeDelayInSeconds = 2f;

        _spawnpoints = gameObject.GetComponentsInChildren<Spawnpoint>();
    }

    private void Start()
    {
        StartCoroutine(SpawnCorutine());
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            _isWorking = false;
        }
    }

    private IEnumerator SpawnCorutine()
    {
        while (_isWorking)
        {
            GetRandomSpawnpoint().SpawnEnemy(_prefab);

            yield return new WaitForSeconds(_timeDelayInSeconds);
        }
    }

    private Spawnpoint GetRandomSpawnpoint()
    {
        return _spawnpoints[Random.Range(0, _spawnpoints.Length)];
    }
}

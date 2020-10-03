using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameObjectsSpawnManager : MonoBehaviour
{
    [SerializeField]
    GameObject _itemToBeSpawn;

    [SerializeField]
    GameObject[] _obstaclesToBeSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnItem", 2.0f);
        Invoke("SpawnObstacle", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnItem()
    {
        GameObject go = Instantiate(_itemToBeSpawn ,
            new Vector3(Random.Range(-1f, 5f), 5, Random.Range(-6f, 6f)),
            Quaternion.identity);
        Destroy(go, 900);

        float nextSpawnTime = Random.Range(0.2f, 1);
        Invoke("SpawnItem", 0.1f);
    }

    void SpawnObstacle(){
        int obsIdx = Random.Range(0, _obstaclesToBeSpawn.Length);
        GameObject go = Instantiate(_obstaclesToBeSpawn[obsIdx],
            new Vector3(Random.Range(-6f, 6f), 5, Random.Range(-6f, 6f)), Quaternion.identity);
        Destroy(go, 900);


        float nextSpawnTime = Random.Range(0.2f, 0.3f);
        Invoke("SpawnObstacle", nextSpawnTime);
    }
}

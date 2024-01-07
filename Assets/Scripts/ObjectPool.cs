using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObjectPool : MonoBehaviour
{
    public GameObject objectToPool;
    public int poolSize = 10;

    private List<GameObject> _pooledObjects;

    void Start()
    {
        // create objects based on pool size
        _pooledObjects = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(objectToPool);
            obj.SetActive(false);
            _pooledObjects.Add(obj);
        }

        // repeat the "SpawnObject" function
        InvokeRepeating("SpawnObject", 0f, 3);
    }

    void SpawnObject()
    {
        for (int i = 0; i < _pooledObjects.Count; i++)
        {
            if (!_pooledObjects[i].activeInHierarchy)
            {
                // Set objects max, min positions accordingly to map scale
                float randomX = Random.Range(-8, 8);
                float randomY = Random.Range(-4, 4);

                // Set the position of the created object and activate the object
                _pooledObjects[i].transform.position = new Vector2(randomX, randomY);
                _pooledObjects[i].SetActive(true);
                break;
            }
        }
    }
}

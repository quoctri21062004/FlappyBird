using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject prefab;
    public GameObject spawnPos;
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;

  
    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn),spawnRate,spawnRate);
    }
    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }
    protected void Spawn()
    {
        GameObject pipe = SimplePool2.Spawn(prefab, spawnPos.transform.position, Quaternion.identity);
        pipe.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}

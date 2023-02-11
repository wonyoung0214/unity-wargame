using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using Week5;

public class Spawner : MonoBehaviour
{
    public GameObject player;
    public GameObject spawnPrefab;
    public float spawnSpan = 5f;
    void Start()
    {
        StartCoroutine(Spawn());
        player = FindObjectOfType<ThirdPersonController>().gameObject;
    }
    
    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnSpan);
            GameObject go = Instantiate(spawnPrefab);
            go.transform.position = transform.position;
            go.GetComponent<NavTest>().target = player.transform;
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutSpawnerScript : MonoBehaviour
{
    public GameObject[] donutPrefabs;
    public float spawnInterval = 1f;
    float minPos, maxPos;
    Transform ovenPosition;

    public void Start()
    {
        ovenPosition = GetComponent<Transform>();
    }
    public void BakeDonut(bool state)
    {
        if (state)
            StartCoroutine(BakeDonut());
        else
            StopAllCoroutines();
        
    }
    IEnumerator BakeDonut()
    {
        while (true)
        {
            minPos = ovenPosition.position.x - 30f;
            maxPos = ovenPosition.position.x + 30f;

            float randomX = Random.Range(minPos, maxPos);
            Vector2 spawnPosition = new Vector2(randomX, ovenPosition.position.y);
            GameObject donut = Instantiate(donutPrefabs[Random.Range(0, donutPrefabs.Length)], spawnPosition, Quaternion.identity,
                ovenPosition);
            yield return new WaitForSeconds(spawnInterval);

            //Iznīcina objektu pēc laika
            //Destroy(gameObject, 5f);
        }
    }

}

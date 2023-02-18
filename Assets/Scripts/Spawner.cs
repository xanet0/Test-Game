using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Spawnpoints;
    public GameObject[] Objects;

    public float timeSpawn;
    public float timeBtwSpawn;
    private int randObject;
    private int randSpawnpoint;

    private void Start()
    {
        //������ �������
        timeBtwSpawn = timeSpawn;
    }

    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            //����� ���������� ������� � ������
            randObject = Random.Range(0, Objects.Length);
            randSpawnpoint = Random.Range(0, Spawnpoints.Length);
            //����� �������
            Instantiate(Objects[randObject], Spawnpoints[randSpawnpoint].transform);
            // ���������� �������
            timeBtwSpawn = timeSpawn;
        }
        else
        {
            //������ �������
            timeBtwSpawn -= Time.deltaTime;
        }


    }
}

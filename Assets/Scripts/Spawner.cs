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
        //Запуск таймера
        timeBtwSpawn = timeSpawn;
    }

    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            //Выбор рандомного объекта и спавна
            randObject = Random.Range(0, Objects.Length);
            randSpawnpoint = Random.Range(0, Spawnpoints.Length);
            //Спавн объекта
            Instantiate(Objects[randObject], Spawnpoints[randSpawnpoint].transform);
            // Обновление таймера
            timeBtwSpawn = timeSpawn;
        }
        else
        {
            //Скрипт таймера
            timeBtwSpawn -= Time.deltaTime;
        }


    }
}

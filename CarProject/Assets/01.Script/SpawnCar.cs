using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : MonoBehaviour
{
    public int SpawnCount = 4;
    //1번 1x1 2가 1x2차

    public List<Transform> spawnPos = new List<Transform>();

    public List<GameObject> car = new List<GameObject>();

    void Start()
    {
        MakeCar();
    }

    private void MakeCar()
    {
        for (int i = 0; i < SpawnCount; i++)
        {
            Debug.Log("생성");
            int what = Random.Range(0, car.Count+1);
            int angle = Random.Range(1,5);
            int where = Random.Range(0, spawnPos.Count+1);

            GameObject CarObj = Instantiate(car[what], 
            spawnPos[where].transform.position
            ,Quaternion.Euler(0, 0, 90*angle));

        }
    }

    void Update()
    {
        
    }
}

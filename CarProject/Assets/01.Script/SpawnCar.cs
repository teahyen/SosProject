using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : MonoBehaviour
{
    //1번 1x1 2가 1x2차
    public static SpawnCar Instance;
    public List<Transform> spawnPos = new List<Transform>();

    public List<GameObject> car = new List<GameObject>();

    void Start()
    {
        StartCoroutine(MakeCar(3));
    }

    private void Update() {
        if(Input.GetMouseButtonDown(0)){
            StartCoroutine(MakeCar(2));
        }
    }

    public IEnumerator MakeCar(int spawnCount)
    {
        for (int i = 0; i < spawnCount; i++)
        {
            int what = Random.Range(0, car.Count);
            int angle = Random.Range(1,5);
            int where = Random.Range(0, spawnPos.Count);

            GameObject CarObj = Instantiate(car[what], 
            spawnPos[where].transform.position
            ,Quaternion.Euler(0, 0, 90*angle));
            
            yield return new  WaitForSeconds(0.01f);

        }
    }
}

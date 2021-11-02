using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashCar : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col) {
        Debug.Log(col.gameObject.name);
        if(col.tag == "Wall"&&col.tag == "Car")
        {
            Debug.Log("파괴");
            SpawnCar.Instance.MakeCar(1);
            Destroy(gameObject);
        }
    }
}

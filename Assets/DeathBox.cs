using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour
{
    public GameObject spawnPoint;

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Player")
        {
            this.transform.position = spawnPoint.transform.position;
        }
    }

}

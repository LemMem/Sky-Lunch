using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomspawner : MonoBehaviour {
    public GameObject[] objectstospawn;

    public void Spawn(Vector3 point)
    {
        int rand = Random.Range(0,objectstospawn.Length);
        Instantiate(objectstospawn[rand], point, Quaternion.identity);
    }
}

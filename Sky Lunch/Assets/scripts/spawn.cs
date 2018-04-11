using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

    randomspawner rs;

    private void Start()
    {
        rs = GameObject.FindGameObjectWithTag("control").GetComponent<randomspawner>();
        rs.Spawn(gameObject.transform.position);
    }
}

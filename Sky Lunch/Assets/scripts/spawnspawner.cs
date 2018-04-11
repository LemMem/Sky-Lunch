using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnspawner : MonoBehaviour {

    randomspawner rs;
    public float timer;
	// Use this for initialization
	void Start () {
        rs = GetComponent<randomspawner>();
	}
    private void Update()
    {
        if(timer <= 0)
        {
            rs.Spawn(new Vector3(0, 0));
            timer = 10;
        }
        timer -= Time.deltaTime;
    }
}

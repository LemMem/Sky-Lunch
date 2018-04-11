using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruit : MonoBehaviour {

    public bool rotten;
    public int amounttoincrease;
    float timer = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(rotten == false)
        {
            collision.GetComponent<Player>().score += amounttoincrease;
        }
        if(rotten)
        {
            collision.GetComponent<Player>().Kill();
        }
        Destroy(gameObject);
    }

    private void Update()
    {
        if(rotten)
        {
            if(timer <= 0)
            {
                timer = 10;
                Destroy(gameObject);
            }
            timer -= Time.deltaTime;
        }
    }

}

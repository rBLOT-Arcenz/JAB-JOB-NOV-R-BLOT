using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        if ((player.transform.position.x - transform.position.x < 0.5 && player.transform.position.x - transform.position.x > -0.5) && (player.transform.position.z - transform.position.z < 0.5 && player.transform.position.z - transform.position.z > -0.5))
        {
            player.GetComponent<InputController>().Key = true;
            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndDetect : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        if ((player.transform.position.x - transform.position.x < 0.5 && player.transform.position.x - transform.position.x > -0.5) && (player.transform.position.z - transform.position.z < 0.5 && player.transform.position.z - transform.position.z > -0.5))
        {
            if (player.GetComponent<InputController>().Key)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}

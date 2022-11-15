using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public Transform transformPlay;

    public void death(Transform Player)
    {
        transformPlay = Player;
        Invoke("deathComp", 1f); //2 is the time
    }

    public void deathComp()
    {
        Debug.Log("T'es MORT");
        transformPlay.position = new Vector3(-13, 20, 0);
    }
}

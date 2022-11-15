using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public bool trigger = false;

    // Update is called once per frame
    void Update()
    {
        if (trigger)
        {
            Application.Quit();
        }
    }
}

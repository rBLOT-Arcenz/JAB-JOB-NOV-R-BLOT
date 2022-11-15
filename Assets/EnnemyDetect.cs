using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyDetect : MonoBehaviour
{

    private float timer = 0f;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1f)
        {
            Destroy(this.gameObject);
        }

        RaycastHit hit;
        Debug.Log("Update");
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 100f))
        {
            Debug.Log("Y");
            if (hit.collider.gameObject.layer == 8)
            {
                Debug.Log("YPPPPPPPP");
                FSMTester fsm = hit.collider.GetComponent<FSMTester>();
                fsm.FSMInfos.Knocked = true;
                Destroy(this.gameObject);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowChara : MonoBehaviour
{
    public Transform chara;

    public float xminus;
    public float yplus;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(chara.position.x - xminus, chara.position.y + yplus, chara.position.z);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMTester : MonoBehaviour
{
    public TSTStateInfo FSMInfos = new TSTStateInfo();
    public bool ShowDebug = false;

    public Transform joueur;
    public Transform Sense;

    private FSMachine<TSTSBase, TSTStateInfo> FSM = new FSMachine<TSTSBase, TSTStateInfo>();

    void Start()
    {
        FSMInfos.joueur = joueur;
        FSMInfos.Sense = Sense;
    }

    void Update()
    {
        FSM.PeriodUpdate = 2;
        FSM.ShowDebug = ShowDebug;
        FSM.Update(FSMInfos);
    }

    void OnCollisionEnter(Collision c)
    {
        Debug.Log("YOOOOOOO");
        if (c.gameObject.tag == "Missile")
        {
            FSMInfos.Knocked = true;
            Destroy(c.gameObject);
        }
    }
}
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TSTSIdle : FSMState<TSTStateInfo>
{
    public override void doState(ref TSTStateInfo infos)
    {
        infos.animator.SetTrigger("idle");
        infos.nav.SetDestination(infos.trans.position);
    }
}
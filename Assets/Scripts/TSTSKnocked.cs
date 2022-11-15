using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TSTSKnocked : FSMState<TSTStateInfo>
{
    public override void doState(ref TSTStateInfo infos)
    {
        infos.lt.intensity = 0;
        infos.lt2.intensity = 0;
        infos.audioSource.PlayOneShot(infos.douleur, 0.4f);
        infos.animator.SetTrigger("idle");
        infos.nav.SetDestination(infos.trans.position);
    }
}

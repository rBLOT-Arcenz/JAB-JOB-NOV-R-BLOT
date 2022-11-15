using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TSTSPoursuite : FSMState<TSTStateInfo>
{
    public override void doState(ref TSTStateInfo infos)
    {
        infos.animator.SetTrigger("run");
        infos.audioSource.PlayOneShot(infos.marche, 0.4f);
        infos.nav.SetDestination(infos.joueur.position);
    }
}
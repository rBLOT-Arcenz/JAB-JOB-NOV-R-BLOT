using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TSTSPatrouille : FSMState<TSTStateInfo>
{
    public override void doState(ref TSTStateInfo infos)
    {
        infos.lt.intensity = 10;
        infos.lt2.intensity = 2;
        infos.lt.color = new Color32(0, 255, 22, 255);
        infos.lt2.color = new Color32(0, 255, 22, 255);

        infos.animator.SetTrigger("run");
        infos.audioSource.PlayOneShot(infos.marche, 0.4f);
        infos.nav.SetDestination(RandomNavMeshPoint.GetRandomPointOnNavMesh());
    }
}
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TSTSAgressif : FSMState<TSTStateInfo>
{
    public override void doState(ref TSTStateInfo infos)
    {
        infos.lt.intensity = 20;
        infos.lt2.intensity = 2;
        infos.lt.color = new Color32(255, 0, 0, 255);
        infos.lt2.color = new Color32(255, 0, 0, 255);

        if (infos.CloseToTarget)
            addAndActivateSubState<TSTSAttaque>();
        else
            addAndActivateSubState<TSTSPoursuite>();

        KeepMeAlive = true;
    }
}
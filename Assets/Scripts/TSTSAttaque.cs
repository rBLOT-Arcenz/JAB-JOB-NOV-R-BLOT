using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TSTSAttaque : FSMState<TSTStateInfo>
{

    public override void doState(ref TSTStateInfo infos)
    {
        infos.animator.SetTrigger("attack");
        Debug.Log("Attaque");
        infos.PlayerDeath.death(infos.joueur);
    }
}

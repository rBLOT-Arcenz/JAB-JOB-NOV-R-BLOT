using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TSTSBase : FSMState<TSTStateInfo>
{
    bool prev = false;

    public override void doState(ref TSTStateInfo infos)
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(infos.Sense.position, infos.Sense.TransformDirection(Vector3.forward), out hit, 1000f))
        {
            if (hit.collider.transform.IsChildOf(infos.joueur) || hit.collider.transform == infos.joueur)
            {
                Debug.Log("Je l'ai vu !");
                infos.CanSeeTarget = true;
                float dist = Vector3.Distance(infos.trans.position, hit.collider.transform.position);
                Debug.Log(dist);
                if (!prev)
                {
                    infos.audioSource.PlayOneShot(infos.surprise, 0.4f);
                }
                prev = true;
                if (dist < 1f)
                {
                    infos.CloseToTarget = true;
                }
                else
                {
                    infos.CloseToTarget = false;
                }
            }
            else
            {
                prev = false;
                infos.CanSeeTarget = false;
                infos.CloseToTarget = false;
            }
        }


        if (infos.Knocked)
        {
            addAndActivateSubState<TSTSKnocked>();
            infos.Knocked = false;
        }
        else if (infos.CanSeeTarget)
        {
            addAndActivateSubState<TSTSAgressif>();
        }
        else
        {
            addAndActivateSubState<TSTSTranquille>();
        }

        KeepMeAlive = true;
    }
}

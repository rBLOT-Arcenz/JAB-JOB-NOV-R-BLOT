using UnityEngine;

[System.Serializable]
public class TSTStateInfo : FSMStateInfo
{
    public bool CanSeeTarget;
    public bool CloseToTarget;
    public bool Knocked;
    public Transform joueur;
    public Transform Sense;

    public Transform trans;
    public Animator animator;
    public UnityEngine.AI.NavMeshAgent nav;

    public AudioClip marche;
    public AudioClip surprise;
    public AudioClip douleur;
    public AudioSource audioSource;

    public Light lt;
    public Light lt2;

    public PlayerDeath PlayerDeath;
}
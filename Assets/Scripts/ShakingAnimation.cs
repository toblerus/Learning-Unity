using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ShakingAnimation : MonoBehaviour {

    [SerializeField] [Range(0,1)] public float duration;
    [SerializeField] [Range(0, 1)] public float strength;
    [SerializeField] [Range(0, 20)] public int leafAmount;

    [SerializeField] private ParticleSystem leafParticleSystem;

    [SerializeField] private Transform treeTransform;

    public void TreeImpactAnimation()
    {
        //treeTransform.DOShakePosition(duration, strength, vibrato, randomness);
        treeTransform.DOKill(true);
        treeTransform.DOPunchPosition(Vector3.up * strength, duration);
        leafParticleSystem.Emit(Random.Range(leafAmount, leafAmount + 5));
    }
}

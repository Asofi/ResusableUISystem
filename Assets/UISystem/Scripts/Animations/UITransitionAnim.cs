using System;
using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(fileName = "UITween", menuName = "GameBakery/Create UITween", order = 0)]
public class UITransitionAnim : ScriptableObject {

    [SerializeField] Ease _ease;

    public void Animate(Transform target, Action callWhenFinished) {
        
    }
}

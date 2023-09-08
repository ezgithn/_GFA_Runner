using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class CoinAnimation : MonoBehaviour
{
    private void Start()
    {
        // transform.DOLocalMoveY(1, 1).SetLoops(-1, LoopType.Yoyo).SetDelay(0.1f * Mathf.Floor(transform.position.z));
        transform.DOLocalRotate(Vector3.up * 360,2.5f, RotateMode.WorldAxisAdd).SetLoops(-1).SetEase(Ease.Linear);
    }
    
    private void OnDestroy()
    {
        transform.DOKill();
    }
}

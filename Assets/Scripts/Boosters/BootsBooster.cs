using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Boosters/Boots")]
public class BootsBooster : Booster
{
    [SerializeField]
    private float _multiplier = 2.5f;
    
    public float bootJumpForce = 15f; 
    private float bootDuration = 5f; 
    private bool isBooting = false;
    
    
    
    public override void OnAdded(BoosterContainer container)
    {
        if (container.TryGetComponent(out PlayerMovement playerMovement))
        {
            playerMovement.JumpPower *= _multiplier;
        }
    }

    public override void OnRemoved(BoosterContainer container)
    {
        if (container.TryGetComponent(out PlayerMovement playerMovement))
        {
            playerMovement.JumpPower /= _multiplier;
        }
    }
    
    public void BootJump(PlayerMovement playerMovement)
    {
        if (isBooting) return;
        isBooting = true;
        playerMovement.JumpPower = bootJumpForce;
        StartCoroutine(BootTimer(playerMovement));
    }
    
}

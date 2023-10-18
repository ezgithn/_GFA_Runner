using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Boosters/Boots")]
public class BootsBooster : Booster
{
    [SerializeField]
    private float _multiplier;
    
    public float bootJumpForce = 35f; 
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
    }

    IEnumerator BootTimer(PlayerMovement playerMovement)
    {
        yield return new WaitForSeconds(bootDuration);
        isBooting = false;
        playerMovement.JumpPower /= _multiplier; 
    }
    
}

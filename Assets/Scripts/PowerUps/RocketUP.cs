using UnityEngine;

[CreateAssetMenu (menuName = "Powerups/RocketUp")]
public class RocketUP : PowerUps
{
    public int amount;
    public override void Apply(GameObject target)
    {
        GameManager.gameManager.UpdateRockets(amount);     
    }
}

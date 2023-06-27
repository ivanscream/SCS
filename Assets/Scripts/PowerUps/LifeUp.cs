using UnityEngine;
[CreateAssetMenu (menuName = "Powerups/LifeUp")]
public class LifeUp : PowerUps
{
    public int amount;
    public override void Apply(GameObject target)
    {
        GameManager.gameManager.UpdateLives(amount);     
    }
}

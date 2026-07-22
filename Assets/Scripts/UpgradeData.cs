using UnityEngine;
[CreateAssetMenu(fileName = "New Upgrade", menuName = "Space Incremental/Upgrade")]
public class UpgradeData : ScriptableObject
{
    public string upgradeName;
    public string upgradeDescription;
    public float energyProductionIncrease;
    public float populationIncrease;
    public float baseCost;
}

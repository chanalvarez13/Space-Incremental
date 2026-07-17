using UnityEngine;
[CreateAssetMenu(fileName = "New Upgrade", menuName = "Space Incremental/Upgrade")]
public class UpgradeData : ScriptableObject
{
    public string upgradeName;
    public string upgradeDescription;
    public double energyProductionIncrease;
    public double populationIncrease;
    public double populationCost;
    public double energyCost;
}

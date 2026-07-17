using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    public UpgradeData upgradeData;
    public UpgradeManager uManager;
    public PlanetManager planet;
    public void PressUpgrade()
    {
        uManager.Upgrade(upgradeData);
    }
}

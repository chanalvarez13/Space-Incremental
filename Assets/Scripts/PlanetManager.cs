using UnityEngine;

public class PlanetManager : MonoBehaviour
{
    [SerializeField] private PlanetData planet;
    private UIManager uiManager;
    private UpgradeManager upgradeManager;
    public string planetDescription;
    public float baseEnergyProduction = 1;
    public float currentEnergyProduction;
    public float Energy;
    public float Population;
    public float energyUpgradesBought;
    public float currentPopulationInflux;

    void Start()
    {
        uiManager = FindAnyObjectByType<UIManager>();
        upgradeManager = FindAnyObjectByType<UpgradeManager>();
        AddProduction();
    }
    public void AddProduction()
    {
        currentEnergyProduction = baseEnergyProduction + energyUpgradesBought;
    }
    void Update()
    {
            Energy += currentEnergyProduction * Time.deltaTime;
        Population += currentPopulationInflux * Time.deltaTime;
    }

    private void OnMouseDown()
    {
        uiManager.OnPlanetPress(this);
        upgradeManager.SelectPlanet(this);
        Debug.Log($"{planet.name} has been clicked!");
    }
}

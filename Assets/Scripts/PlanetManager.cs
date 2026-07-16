using UnityEngine;

public class PlanetManager : MonoBehaviour
{
    [SerializeField] private PlanetData planet;
    private UIManager uiManager;
    public string planetDescription;
    public double baseEnergyProduction = 1;
    public double currentEnergyProduction;
    public double Energy;
    public double Population;
    public double energyUpgradesBought;
    public double currentPopulationInflux;
    private float timer = 0f;

    void Start()
    {
        uiManager = FindAnyObjectByType<UIManager>();
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            currentEnergyProduction = baseEnergyProduction + energyUpgradesBought;
            Energy = Energy + currentEnergyProduction;
            timer -= 1f;
        }
    }

    private void OnMouseDown()
    {
        uiManager.OnPlanetPress(this);
        Debug.Log($"{planet.name} has been clicked!");
        Debug.Log($"{planet.name} has {Energy} Energy.");
    }
}

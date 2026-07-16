using UnityEngine;

public class PlanetManager : MonoBehaviour
{
    [SerializeField] private PlanetData planet;
    private UIManager uiManager;
    public double baseProduction = 1;
    public double currentProduction;
    public double Energy;
    public double Population;
    public double upgradesBought;
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
            Energy = Energy + planet.baseProduction;
            currentProduction = baseProduction + upgradesBought;
            timer -= 1f;
        }
    }

    private void OnMouseDown()
    {
        uiManager.OnPlanetPress(this);
        Debug.Log($"{planet.name} has been clicked!");
    }
}

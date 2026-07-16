using UnityEngine;

public class PlanetManager : MonoBehaviour
{
    public PlanetData planet;
    public double baseProduction = 1;
    public double currentProduction;
    public double Energy;
    public double Population;
    public double upgradesBought;
    private float timer = 0f;

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
}

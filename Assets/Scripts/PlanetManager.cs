using UnityEngine;

public class PlanetManager : MonoBehaviour
{
    [SerializeField] private PlanetData planet;
    public double Energy;
    public double Population;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            Energy++;
            timer -= 1f;
        }
    }
}

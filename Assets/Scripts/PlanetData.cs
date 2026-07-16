using UnityEngine;
[CreateAssetMenu(fileName = "New Planet", menuName = "Space Incremental/Planet")]
public class PlanetData : ScriptableObject
{
    public string planetName;
    public double baseProduction;
    public double worth;
    public string planetDescription;
}

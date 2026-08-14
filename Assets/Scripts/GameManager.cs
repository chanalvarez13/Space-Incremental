using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float Blood;
    public Text bloodNum;

public void UpdateBlood()
    {
        bloodNum.text = NumberFormatter.Format(Blood);
    }
}

using UnityEngine;
using UnityEngine.UI;

public class PlanetViewerUI : MonoBehaviour
{
    public GameObject PlanetViewInfo;
    public GameObject PanelChoice;
    public void OnMouseDown()
    {
        Debug.Log(gameObject.name + " was clicked!");
        OpenViewer();
    }

    public void OpenViewer()
    {
            PlanetViewInfo.SetActive(true);
            PanelChoice.GetComponent<Text>().text = "Name: ";
    }
}

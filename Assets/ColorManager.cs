using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    private Color originalColor;

    private void ChangeColor(float red, float green, float blue)
    {
        gameObject.GetComponent<MeshRenderer>().material.color = new Color(red, green, blue);
    }

    public void ChangeColorToRed(InputEventData eventData)
    {
        ChangeColor(255, 0, 0);
    }
    public void ChangeColorToGreen(InputEventData eventData)
    {
        ChangeColor(0, 255, 0);
    }
    public void ChangeColorToBlue(InputEventData eventData)
    {
        ChangeColor(0, 0, 255);
    }
    public void Reset(InputEventData eventData)
    {
        ChangeColor(originalColor.r, originalColor.g, originalColor.b);
    }

    void Start()
    {
        originalColor = gameObject.GetComponent<MeshRenderer>().material.color;
    }

}

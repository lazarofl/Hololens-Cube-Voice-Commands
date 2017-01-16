using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class SizeManager : MonoBehaviour
{
    private Vector3 originalSize;

    public void MakeBigger(InputEventData eventData)
    {
        gameObject.transform.localScale +=
            new Vector3(originalSize.x, originalSize.y, originalSize.z);
    }

    public void MakeSmaller(InputEventData eventData)
    {
        gameObject.transform.localScale -=
            new Vector3(originalSize.x, originalSize.y, originalSize.z);
    }

    void Start()
    {
        originalSize = gameObject.transform.localScale;
    }

}

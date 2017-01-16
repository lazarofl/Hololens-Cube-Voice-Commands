using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class RotateManager : MonoBehaviour, IInputClickHandler
{
    public bool IsRotating = false;

    private float X = 1;
    private float Y = 1;
    private float Z = 1;

    public void OnStartRotationIsCalled(InputEventData eventData)
    {
        IsRotating = true;
    }
    public void OnStopRotationIsCalled(InputEventData eventData)
    {
        IsRotating = false;
    }
    public void OnInvertRotationIsCalled(InputEventData eventData)
    {
        X *= -1;
        Y *= -1;
        Z *= -1;
    }

    public void OnInputClicked(InputEventData eventData)
    {
        IsRotating = !IsRotating;
    }

    void Update()
    {
        if (IsRotating)
            gameObject.transform.Rotate(X, Y, Z);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBounds : MonoBehaviour
{
    public static float MinX;
    public static float MaxX;
    public static float MinY;
    public static float MaxY;

    private void Start()
    {
        Camera mainCamera = Camera.main;
        float screenHeight = mainCamera.orthographicSize;
        float screenWidth = screenHeight * mainCamera.aspect;

        MinX = mainCamera.transform.position.x - screenWidth;
        MaxX = mainCamera.transform.position.x + screenWidth;
        MinY = mainCamera.transform.position.y - screenHeight;
        MaxY = mainCamera.transform.position.y + screenHeight;
    }
}

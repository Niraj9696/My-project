using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class CubeDcolor : MonoBehaviour
{
    public CubeCcolor cubeA; // Reference to CubeA
    private Renderer cubeRenderer;

    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();

        if (cubeA != null)
        {
            // Subscribe to CubeA's color change event
            cubeA.OnColorChange += UpdateColor;
        }
        else
        {
            Debug.LogError("CubeA reference not assigned in CubeB!");
        }
    }

    void UpdateColor(Color newColor)
    {
        // Apply CubeA's new color to CubeB
        cubeRenderer.material.color = newColor;
    }

    void OnDestroy()
    {
        if (cubeA != null)
        {
            // Unsubscribe when CubeB is destroyed to avoid errors
            cubeA.OnColorChange -= UpdateColor;
        }
    }
}

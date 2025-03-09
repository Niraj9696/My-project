using UnityEngine;

public class CubeCcolor : MonoBehaviour
{
    private Renderer cubeRenderer;
    private Color currentColor;

    public delegate void ColorChangeEvent(Color newColor);
    public event ColorChangeEvent OnColorChange; // Event for CubeB to listen to

    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
        InvokeRepeating(nameof(ChangeColor), 2f, 2f); // Change color every 2 seconds
    }

    void ChangeColor()
    {
        // Generate a new random color
        currentColor = new Color(Random.value, Random.value, Random.value);
        cubeRenderer.material.color = currentColor;

        // Notify CubeB that color has changed
        OnColorChange?.Invoke(currentColor);
    }
}

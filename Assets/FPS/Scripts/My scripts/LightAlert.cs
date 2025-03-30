using UnityEngine;

public class VisualAlert1 : MonoBehaviour, IAlert
{
    public Renderer objectRenderer;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    public void TriggerAlert()
    {
        objectRenderer.material.color = Random.ColorHSV();
        Debug.Log("VisualAlert: Changing color as an alert!");
    }
}

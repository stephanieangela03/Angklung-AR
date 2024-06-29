using UnityEngine;
using UnityEngine.UI;

public class ToggleDescriptionVisibility : MonoBehaviour
{
    public GameObject Description; // Reference to the description image UI element
    public Button InfoButton; // Reference to the Button UI element

    void Start()
    {
        // Ensure the description image is initially inactive
        if (Description != null)
        {
            Description.SetActive(false);
        }

        // Register the button click event
        if (InfoButton != null)
        {
            InfoButton.onClick.AddListener(ToggleVisibility);
        }
        else
        {
            Debug.LogWarning("Toggle button is not assigned.");
        }
    }

    public void ToggleVisibility()
    {
        // Toggle the active state of the description image
        if (Description != null)
        {
            Description.SetActive(!Description.activeSelf);
        }
        else
        {
            Debug.LogWarning("Description image is not assigned.");
        }
    }
}

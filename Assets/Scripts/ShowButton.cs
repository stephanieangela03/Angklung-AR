using UnityEngine;
using Vuforia;

public class ShowButton : MonoBehaviour
{
    public GameObject uiButton;
    private ObserverBehaviour mObserverBehaviour;

    void Start()
    {
        mObserverBehaviour = GetComponent<ObserverBehaviour>();
        if (mObserverBehaviour)
        {
            mObserverBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }

        // Ensure the button is initially inactive
        uiButton.SetActive(false);
    }

    void OnDestroy()
    {
        if (mObserverBehaviour)
        {
            mObserverBehaviour.OnTargetStatusChanged -= OnTargetStatusChanged;
        }
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED || targetStatus.Status == Status.EXTENDED_TRACKED)
        {
            // Object is being tracked
            uiButton.SetActive(true);
        }
        else
        {
            // Object is lost
            uiButton.SetActive(false);
        }
    }
}

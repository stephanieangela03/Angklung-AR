using UnityEngine;
using Vuforia;

public class ImageTargetVisibility : MonoBehaviour
{
    private ObserverBehaviour mObserverBehaviour;

    void Start()
    {
        // Get the ObserverBehaviour component
        mObserverBehaviour = GetComponent<ObserverBehaviour>();
        if (mObserverBehaviour)
        {
            mObserverBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }
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
            gameObject.SetActive(true);
        }
        else
        {
            // Object is lost
            gameObject.SetActive(false);
        }
    }
}

using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class GrabCheck : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;
    [SerializeField] private AudioSource sound;

    void Start()
    {   
        grabInteractable = GetComponent<XRGrabInteractable>();

        // Subscribe to grab events
        grabInteractable.selectEntered.AddListener(OnGrab);
        grabInteractable.selectExited.AddListener(OnRelease);
    }

    private void OnGrab(SelectEnterEventArgs args)
    {  
       sound.Play();
    }

    private void OnRelease(SelectExitEventArgs args)
    {   
        sound.Pause();
    }

    void OnDestroy()
    {
        grabInteractable.selectEntered.RemoveListener(OnGrab);
        grabInteractable.selectExited.RemoveListener(OnRelease);
    }
}

//Vector3(355.970001,90,0)
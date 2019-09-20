// -------------------------------------------------------------------------
// CLASS	:	SignalListener
// Desc		:	Registers to a signal and triggers unity events when signal 
//              raises the event.
// Borrowed from: https://unity3d.com/how-to/architect-with-scriptable-objects
// -------------------------------------------------------------------------

// TODO: Create a Signal Listener Collection that allows for multiple signals and events:

using UnityEngine;
using UnityEngine.Events;

public class SignalListener : MonoBehaviour
{
    // Inspector Assigned Field(s):
    public Signal signal;
    public UnityEvent signalEvent;

    /// <summary>
    /// Public method to raise the event(s):
    /// </summary>
    public void OnSignalRaised()
    {
        signalEvent.Invoke();
    }

    /// <summary>
    /// Called when this gameObject is enabled:
    /// Will register itself with the signal;
    /// </summary>
    private void OnEnable()
    {
        signal.RegisterListener(this);
    }

    /// <summary>
    /// Called when this gameObject is disabled:
    /// Will unregister itself with the signal;
    /// </summary>
    private void OnDisable()
    {
        signal.UnRegisterListener(this);
    }
}
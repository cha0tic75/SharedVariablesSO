// -------------------------------------------------------------------------
// CLASS	:	Signal
// Desc		:	Scriptable Object used as a broadcast system
// Borrowed from: https://unity3d.com/how-to/architect-with-scriptable-objects
// -------------------------------------------------------------------------

using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Assets/Scriptable Objects/SharedVariables/Signal", fileName = "New Signal")]
public class Signal : ScriptableObject
{
    public List<SignalListener> listeners = new List<SignalListener>();

    /// <summary>
    /// Public method to raise the events:
    /// </summary>
    public void Raise()
    {
        for (int i = listeners.Count -1; i >= 0; i--)
        {
            listeners[i].OnSignalRaised();
        }
    }

    /// <summary>
    /// Public method to register a listener:
    /// </summary>
    /// <param name="listener"></param>
    public void RegisterListener(SignalListener listener)
    {
        listeners.Add(listener);
    }

    /// <summary>
    /// Public method to un-register a listener:
    /// </summary>
    /// <param name="listener"></param>
    public void UnRegisterListener(SignalListener listener)
    {
        if (listeners.Contains(listener)) listeners.Remove(listener);
    }
}

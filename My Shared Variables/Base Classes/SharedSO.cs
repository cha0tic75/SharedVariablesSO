// -------------------------------------------------------------------------
// CLASS	:	SharedSO
// Desc		:	Base class of all my shared variables.
// Author	:	Tim McCune
// -------------------------------------------------------------------------

using UnityEngine;

public abstract class SharedSO : ScriptableObject, ISerializationCallbackReceiver
{
    #region Inspector Assigned Value(s):
    [Tooltip("Set this to true if you wish the runtime value to revert back to the inspector assigned value, when the game exits play mode or is deserialized again. Setting to false will preserve the runtime value.")]
    [SerializeField] protected bool _resetAfterDeserialize = true;
    #endregion

    #region Method(s):
    /// <summary>
    /// Method used to set the runtime value to the inspector assigned value
    /// </summary>
    protected virtual void Reset() { }
    #endregion

    #region ISerializationCallbackReceiver Interface Method(s):
    public virtual void OnAfterDeserialize()
    {
        if (_resetAfterDeserialize) Reset();
    }

    public virtual void OnBeforeSerialize() { } // Unused
    #endregion
}
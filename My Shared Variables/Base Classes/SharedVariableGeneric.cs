// -------------------------------------------------------------------------
// CLASS	:	SharedVariableGeneric
// Desc		:	Abstract Base class for all Shared variables declared using generics
// Author	:	Tim McCune
// -------------------------------------------------------------------------

using UnityEngine;

public abstract class SharedVariableGeneric<T> : SharedSO
{
    #region Inspector Assigned Field(s):
    [Tooltip("This is the value that will be set in the internal runtime value. NOTE: You will not see this value change during game play./nTo see a change in value, monitor the runtime value.")]
    [SerializeField] protected T _value;
    #endregion

    #region Internal Field(s):
    // Private Field(s):
    private bool _hasRuntimeValueBeenSet = false;

    // Protected Field(s):
    protected T _runtimeValue;
    #endregion

    #region Properties:
    public T Value
    {
        get
        {
            // Fetching the runtime value but it may not be set yet:
            if (!_hasRuntimeValueBeenSet)
            {
                Reset();
                _hasRuntimeValueBeenSet = true;
            }

            return _runtimeValue;
        }
        set { _runtimeValue = value; }
    }
    #endregion

    #region Method(s):
    /// <summary>
    /// Method used to set the runtime value to the inspector assigned value
    /// </summary>
    protected override void Reset() { _runtimeValue = _value; }
    #endregion
}
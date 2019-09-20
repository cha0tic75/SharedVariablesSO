// -------------------------------------------------------------------------
// CLASS	:	SharedRangeVariableGeneric
// Desc		:	Abstract Base class for all Shared variables declared using generics
//				to be used as a range.
// Author	:	Tim McCune
// -------------------------------------------------------------------------

using UnityEngine;

public abstract class SharedRangeVariableGeneric<T> : SharedSO
{
    #region Inspector Assigned Field(s):
    [SerializeField] protected T _minValue;
    [SerializeField] protected T _maxValue;
    #endregion

    #region Internal Field(s):
    private bool _hasMinValueBeenSet = false;
    private bool _hasMaxValueBeenSet = false;

    protected T _minRuntimeValue;
    protected T _maxRuntimeValue;
    #endregion

    #region Properties:
    //Property - Get/Set min runtime value:
    public T minValue
    {
        get
        {
            if (!_hasMinValueBeenSet)
            {
                _minRuntimeValue = _minValue;
                _hasMinValueBeenSet = true;
            }

            return _minRuntimeValue;
        }
        set { _minRuntimeValue = value; }
    }

    // Property - Get/Set max runtime value:
    public T maxValue
    {
        get
        {
            if (!_hasMaxValueBeenSet)
            {
                _maxRuntimeValue = _maxValue;
                _hasMaxValueBeenSet = true;
            }
            return _maxRuntimeValue;
        }
        set { _maxRuntimeValue = value; }
    }
    #endregion

    #region Method(s):
    /// <summary>
    /// Method used to set the runtime value to the inspector assigned value
    /// </summary>
    protected override void Reset()
    {
        _minRuntimeValue = _minValue;
        _maxRuntimeValue = _maxValue;
    }
    #endregion
}
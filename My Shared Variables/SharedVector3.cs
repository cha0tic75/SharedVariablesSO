// -------------------------------------------------------------------------
// CLASS	:	SharedVector3
// Desc		:	Definition of Vector3 as a scriptable Object
// Author	:	Tim McCune
// -------------------------------------------------------------------------

using UnityEngine;

[CreateAssetMenu(menuName = "Assets/Scriptable Objects/SharedVariables/Shared Vector3", fileName = "New Shared Vector3")]
public class SharedVector3 : SharedVariableGeneric<Vector3>
{
    #region Properties:
    public float x
    {
        get { return Value.x; }
        set { Value = new Vector3(value, Value.y, Value.z); }
    }
    public float y
    {
        get { return Value.y; }
        set { Value = new Vector3(Value.x, value, Value.z); }
    }
    public float z
    {
        get { return Value.z; }
        set { Value = new Vector3(Value.x, Value.y, value); }
    }
    #endregion
}
// -------------------------------------------------------------------------
// CLASS	:	SharedVector2
// Desc		:	Definition of Vector 2 as a Scriptable Object
// Author	:	Tim McCune
// -------------------------------------------------------------------------

using UnityEngine;

[CreateAssetMenu(menuName = "Assets/Scriptable Objects/SharedVariables/Shared Vector2", fileName = "New Shared Vector2")]
public class SharedVector2 : SharedVariableGeneric<Vector2>
{
    #region Properties:
    public float x
    {
        get { return Value.x; }
        set { Value = new Vector2(value, Value.y); }
    }
    public float y
    {
        get { return Value.y; }
        set { Value = new Vector2(Value.x, value); }
    }
    #endregion
}
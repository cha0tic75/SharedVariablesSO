// -------------------------------------------------------------------------
// CLASS	:	SharedString
// Desc		:	Definition of String as a Scriptable Object
// Author	:	Tim McCune
// -------------------------------------------------------------------------

using UnityEngine;

[CreateAssetMenu(menuName = "Assets/Scriptable Objects/SharedVariables/Shared String", fileName = "New Shared String")]
public class SharedString : SharedVariableGeneric<string>
{
    #region Properties:
	// TODO: This really doesnt determine whether there's data in the runtime value:
    public bool ContainsData { get { return _runtimeValue != string.Empty && _runtimeValue.Length > 0; } }
    #endregion

    #region Method(s):
    public void Clear() { _runtimeValue = string.Empty; }
    #endregion
}

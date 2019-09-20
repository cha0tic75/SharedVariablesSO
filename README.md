# SharedVariablesSO
My approach to Unity's ScriptableObject as a way to decouple references.

This concept was borrowed from 2 unity talks:
Richard Fine's Unite 2016 - Overthrowing the MonoBehaviour Tyranny in a Glorious Scriptable Object Revolution
(https://www.youtube.com/watch?v=6vmRwLYWNRo)
Ryan Hipple's Unite Austin 2017 - Game Architecture with Scriptable Objects 
(https://www.youtube.com/watch?v=raQ3iHhE_Kk)

My approach uses C# generics in the base class to avoid duplicate code. It also impements ISerializationCallbackReceiver so that a runtime value can be used without affecting the inspector assigned value. The interface will revert the runtime value back to the inspector assigned value on game stop (unless the resetAfterDeserialize boll is unticked)

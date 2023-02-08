using UnityEngine;

[System.Serializable]

public struct TransformDatas
{
    public Vector3 Position;
    public Vector3 Orientation;
}
[CreateAssetMenu(menuName = "New Scenario")]
public class Scenarios : ScriptableObject
{
    public TransformDatas[] positions;
}
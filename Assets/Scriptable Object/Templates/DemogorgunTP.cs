using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon Data", menuName = "Weapon Data/Demogorgun")]
public class DemogorgunTP : ScriptableObject
{
    [SerializeField] private float frontForce = 500.0f;
    [SerializeField] private float upForce = 500.0f;

    public float FrontForce { get { return frontForce; } }
    public float UpForce { get { return upForce; } }
}

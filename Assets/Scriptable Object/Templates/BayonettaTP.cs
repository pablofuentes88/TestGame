using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon Data", menuName = "Weapon Data/Bayonetta")]
public class BayonettaTP : ScriptableObject
{
    [SerializeField] private float radius = 5.0f;
    [SerializeField] private float power = 500.0f;
    [SerializeField] private float frontForce = 500.0f;

    public float Radius { get { return radius; } }
    public float Power { get { return power; } }
    public float FrontForce { get { return frontForce; } }
}

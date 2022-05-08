using UnityEngine;

[CreateAssetMenu(fileName ="New Weapon Data", menuName = "Weapon Data/GunOfLeila")]
public class GunOfLeilaTP : ScriptableObject
{
    [SerializeField] private float magnetDistance = 3f;
    [SerializeField] private float rotateAroundVelocity = 200;
    [SerializeField] private float verticalForce = 10.0f;

    public float MagnetDistance { get { return magnetDistance; } }
    public float RotateAroundVelocity { get { return rotateAroundVelocity; } }
    public float VerticalForce { get { return verticalForce; } }
}



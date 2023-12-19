using UnityEngine;

public class Mortar : Cannon
{
    [Header("Transform")]
    [SerializeField] private Transform _cannon = null;
    [Space]
    [Header("Parameters")]
    [SerializeField] private Vector2 _axis = Vector2.zero;

    private void Awake()
    {
        ApplyRotation();
    }

    private void ApplyRotation()
    {
        _cannon.rotation = Quaternion.Euler(_axis.y, _axis.x, 0);
    }

    public override void Rotate(Vector2 axisParameters)
    {
        _axis.x = Mathf.Clamp(_axis.x + axisParameters.x, -45.0f, 45.0f);
        _axis.y = Mathf.Clamp(_axis.y - axisParameters.y, -45.0f, 10.0f);
        ApplyRotation();
    }
}
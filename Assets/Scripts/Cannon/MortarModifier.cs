using UnityEngine;

public class MortarModifier : Mortar
{
    [SerializeField] private Vector2 _multiplier = Vector2.one;

    public override void Rotate(Vector2 axisParameters)
    {
        base.Rotate(axisParameters * _multiplier);
    }
}
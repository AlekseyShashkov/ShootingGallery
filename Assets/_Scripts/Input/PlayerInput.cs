using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Mortar _cannon = null;
    [SerializeField, Range(1f, 100f)] private float _rotationSpeed = 1.0f;

    void Update()
    {
        _cannon.Rotate(
            new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"))
            * Time.deltaTime * _rotationSpeed);

        if (Input.GetKeyDown(KeyCode.F)) {
            ProjectileStore.Instance.Fire();
        }
    }
}
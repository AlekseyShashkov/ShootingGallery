using UnityEngine;

public class PlayerInput : MonoBehaviour
{ 
    [SerializeField] private Mortar _cannon = null;
    [SerializeField] private ProjectileStore _projectileStore = null;
    [SerializeField] private float _rotationSpeed = 1.0f;

    private void Update()
    {
        _cannon.Rotate(
            new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"))
            * Time.deltaTime * _rotationSpeed);

        if(Input.GetKeyDown(KeyCode.F)) {
            _projectileStore.Fire();
        }
    }
}
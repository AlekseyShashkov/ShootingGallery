using System.Collections.Generic;
using UnityEngine;

public class ProjectileStore : MonoBehaviour
{
    [Header("Projectile spawn point")]
    [SerializeField] private Transform _launcher = null;
    [Space, Header("Parameters")]
    [SerializeField] private GameObject _projectile = null;
    [SerializeField, Range(1f, 50f)] private float _speed = 20.0f;
    [SerializeField] private int _amount = 3;
    [SerializeField] private bool _isOverStore = false;

    private List<GameObject> _projectileStore = new List<GameObject>();

    public static ProjectileStore Instance = null;

    void Awake()
    {
        Instance = this;

        if (_projectile != null && _amount > 0) 
        {
            for (int i = 0; i < _amount; ++i) 
            {
                GameObject projectile = Instantiate(_projectile);
                projectile.SetActive(false);
                _projectileStore.Add(projectile);
            }
        }
    }

    public GameObject GetProjectile (Vector3 position, Quaternion rotation) 
    {
        foreach (var projectile in _projectileStore) {
            if (!projectile.activeInHierarchy) {
                projectile.transform.position = position;
                projectile.transform.rotation = rotation;
                projectile.SetActive(true);
                return projectile;
            }
        }

        if (_isOverStore) {
            GameObject projectile = Instantiate(_projectile, position, rotation);
            _projectileStore.Add(projectile);
            return projectile;
        }

        return null;
    }

    public void Fire()
    {
        GameObject fireProjectile = GetProjectile(_launcher.transform.position,
                                                  _launcher.transform.rotation);

        if(fireProjectile) {
            fireProjectile.GetComponent<Rigidbody>().velocity = 
                _launcher.transform.forward * _speed;
        }
    }
}
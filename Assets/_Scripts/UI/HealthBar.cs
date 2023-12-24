using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _healthbarSprite = null;
    [SerializeField] private float _reduceSpeed = 2f;

    private Camera _camera = null;
    private float _target = 1f;
    
    void Awake() => _camera = Camera.main;

    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position 
                                                     - _camera.transform.position);
        
        _healthbarSprite.fillAmount = Mathf.MoveTowards(
            _healthbarSprite.fillAmount, _target, _reduceSpeed * Time.deltaTime);
    }

    public void UpdateHealthBar(float maxHealth, float currentHealth)
    {
        _target = currentHealth / maxHealth;
    }
}
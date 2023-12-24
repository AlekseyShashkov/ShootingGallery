using System.Collections;
using UnityEngine;
using DG.Tweening;

public class Cube : Target, IDestroyAfterTime
{
    [SerializeField] private HealthBar _healthbar = null;
    [SerializeField] private Explosion _explosion = null;
    [SerializeField, Range(1f, 100f)] private float _maxHealth = 10f;
    [SerializeField, Range(0f, 0f)] private float _destroyTime = 0f;
 
    private float _currentHealth = 0f;
    
    void Start()
    {
        _currentHealth = _maxHealth;
        _healthbar.UpdateHealthBar(_maxHealth, _currentHealth);
    }

    void OnEnable()
    {
        transform.DOMoveX(Random.Range(-12f, 12f),
                          4f).SetEase(Ease.InOutCubic).SetLoops(-1, LoopType.Yoyo);
    }

    public override void GetDamage()
    {
        _currentHealth -= Random.Range(1.5f, 3.5f);
        _healthbar.UpdateHealthBar(_maxHealth, _currentHealth);

        if (_currentHealth <= 0f) {
            Death();
        }
    }

    public override void Death()
    {
        UIManager.Instance.SetScore(1);
        Instantiate(_explosion,transform.position,transform.rotation);
        StartCoroutine(DestroyAfterTime(_destroyTime));
    }

    public override void Respawn()
    {
        _currentHealth = _maxHealth;
        _healthbar.UpdateHealthBar(_maxHealth, _currentHealth);
    }

    public IEnumerator DestroyAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        gameObject.SetActive(false);
    }
}

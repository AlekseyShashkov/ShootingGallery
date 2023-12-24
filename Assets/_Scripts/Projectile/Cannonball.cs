using System.Collections;
using UnityEngine;

public class Cannonball : Projectile, IDestroyAfterTime
{
    [SerializeField, Range(0.5f, 3f)] private float _destroyTime = 1.0f;
    
    void OnEnable()
    {
        StartCoroutine(DestroyAfterTime(_destroyTime));
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Target>(out var target)) {
            target.GetDamage();
        }   
    }

    public IEnumerator DestroyAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        gameObject.SetActive(false);
    }
}
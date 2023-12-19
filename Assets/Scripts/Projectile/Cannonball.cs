using System.Collections;
using UnityEngine;

public class Cannonball : Projectile, IDestroyAfterTime
{
    [SerializeField] private GameObject _explosion = null;
    [SerializeField] private float _lifeTime = 3.0f;
    private bool isExplosion = false;
  
    private void OnCollisionEnter()
    {
        if(!isExplosion) {
        Instantiate(_explosion,transform.position,transform.rotation);
        isExplosion = true;
        }
        StartCoroutine(DestroyAfterTime(_lifeTime));
    }

    public IEnumerator DestroyAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        gameObject.SetActive(false);
        isExplosion = false;
    }
}
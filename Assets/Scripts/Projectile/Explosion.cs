using System.Collections;
using UnityEngine;

public class Explosion : MonoBehaviour, IDestroyAfterTime
{
    [SerializeField] private float _lifeTime = 2.0f;

    void Start()
    {
        StartCoroutine(DestroyAfterTime(_lifeTime));
    }

    public IEnumerator DestroyAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
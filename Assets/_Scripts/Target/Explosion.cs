using System.Collections;
using UnityEngine;

public class Explosion : MonoBehaviour, IDestroyAfterTime
{
    [SerializeField, Range(1f, 3f)] private float _destroyTime = 1.0f;

    void Start()
    {
        StartCoroutine(DestroyAfterTime(_destroyTime));
    }

    public IEnumerator DestroyAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
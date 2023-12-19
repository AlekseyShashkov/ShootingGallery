using System.Collections;
using UnityEngine;

public class Cube : Target, IDestroyAfterTime
{
    [Header("Color change")]
    [SerializeField] private float _lifeTime = 2.0f;  

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Cannonball")) {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            StartCoroutine(DestroyAfterTime(_lifeTime));     
        }
    //Debug.Log($"{gameObject.name} is colliding with {collision.collider.name}");
    }

    public IEnumerator DestroyAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
}

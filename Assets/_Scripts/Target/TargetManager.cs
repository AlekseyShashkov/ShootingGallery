using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    [SerializeField] private GameObject _target = null;
    [SerializeField, Range(1f, 5f)] private float _respawnTime = 3f;

    private GameObject[] _targetStore = new GameObject[3];

    void Awake()
    {
        for (int i = 0; i < _targetStore.Length; ++i) 
        {
            GameObject target = Instantiate(_target);
            target.transform.position = new Vector3(Random.Range(-10f, 10f), 
                                                    Random.Range(2f, 4f), 
                                                    Random.Range(-15f, -5f));
            target.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            _targetStore[i] = target;
        }
    }

    void Update()
    {
        foreach (var target in _targetStore) {
            if (!target.activeInHierarchy) {
                target.transform.position = new Vector3(Random.Range(-10f, 10f), 
                                                        Random.Range(2f, 4f), 
                                                        Random.Range(-15f, -5f));
                target.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                target.GetComponent<Target>().Respawn();
                StartCoroutine(RespawnAfterTime(target, _respawnTime));
            }
        }
    }

    public IEnumerator RespawnAfterTime(GameObject target, float time)
    {
        yield return new WaitForSeconds(time);
        target.SetActive(true);        
    }
}

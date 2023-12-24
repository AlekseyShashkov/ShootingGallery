using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{ 
    [SerializeField] private TextMeshProUGUI scoreText = null;

    public static UIManager Instance = null;
    private float _score = 0f;

    void Awake() => Instance = this;

    void Start()
    {
        SetScore(0f);
    }

    public void SetScore(float score)
    {
        scoreText.text = $"Score: {_score += score}";
    }
}

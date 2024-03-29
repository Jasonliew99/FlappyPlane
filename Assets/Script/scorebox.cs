using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorebox : MonoBehaviour
{
    public int ScoreAmount = 10;

    private ScoreManager _scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        _scoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("Collission happen");

        if (_scoreManager == null)
        {
            //Debug.Log("no ScoreManager");

            return;
        }
        if (!col.gameObject.CompareTag("Player"))
        {
            //Debug.Log("not player");
            return;
        }

        _scoreManager.AddScore(ScoreAmount);
        //Debug.Log("Current Score");
    }
}

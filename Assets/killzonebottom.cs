using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killzonebottom : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
            Debug.Log("player goes bottom");
        GameObject.Destroy(col.gameObject);

        SceneManager.LoadScene("GameOver");


    }
}

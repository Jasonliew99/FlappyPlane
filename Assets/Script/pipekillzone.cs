using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pipekillzone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("player die");
        GameObject.Destroy(col.gameObject);
       
        SceneManager.LoadScene("GameOver");
    }
}

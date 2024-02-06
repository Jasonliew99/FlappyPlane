using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipekillzone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject.Destroy(col.gameObject);
    }
}

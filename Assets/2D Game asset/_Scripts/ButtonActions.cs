using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActions : MonoBehaviour
{
    public GameObject deathWall;
    public GameObject Player;

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player")) {
            deathWall.transform.localScale = Vector3.zero;
            this.transform.localScale = Vector3.zero;
        }
    }
}

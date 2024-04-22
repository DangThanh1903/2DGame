using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject Player;
    public GameObject StartPoint;

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player")) {
            Die();
        }
    }
    void Die() {
        StartCoroutine(Respawn(0.5f));
    }
    IEnumerator Respawn(float duration) {
        Rigidbody2D playerRigidbody = Player.GetComponent<Rigidbody2D>();
        playerRigidbody.simulated = false;
        Player.transform.localScale = Vector3.zero;
        yield return new WaitForSeconds(duration);
        Player.transform.position = StartPoint.transform.position;
        playerRigidbody.simulated = true;
        Player.transform.localScale = Vector3.one;
    }
}


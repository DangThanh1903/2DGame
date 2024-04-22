using UnityEngine;

public class FinishLine : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player")) {
            ScenceControler.instance.NextLevel();
        }
    }
}

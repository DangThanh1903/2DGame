using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceControler : MonoBehaviour
{
    public static ScenceControler instance;
    public float loadingScenceTime = 1f;
    [SerializeField] Animator transitionAnim;

    private void Awake() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }
    public void NextLevel() {
        int sceneCount = SceneManager.sceneCountInBuildSettings;
        if (sceneCount == SceneManager.GetActiveScene().buildIndex + 1) {
            SceneManager.LoadSceneAsync(0);
        }
        else {
            StartCoroutine(LoadLevel());
        }
    }

    IEnumerator LoadLevel() {
        
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(loadingScenceTime);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        transitionAnim.SetTrigger("Start");
    }
}

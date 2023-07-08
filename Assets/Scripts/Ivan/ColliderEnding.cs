using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderEnding : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "DumbAlly")
        {
            StartCoroutine("UpdateScene");
        }
    }

    IEnumerator UpdateScene()
    {
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

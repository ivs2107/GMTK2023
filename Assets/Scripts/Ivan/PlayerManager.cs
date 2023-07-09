using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "WallBlock")
        {

            try
            {
                GameObject.Find("SoundEffectExplosion").GetComponent<AudioSource>().Play();
            }
            catch
            {

            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "WallBlock")
        {

            try
            {
                GameObject.Find("SoundEffectExplosion").GetComponent<AudioSource>().Play();
            }
            catch
            {

            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        }
    }

}

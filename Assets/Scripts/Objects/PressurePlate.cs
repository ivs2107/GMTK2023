using UnityEngine;
using DG.Tweening;
using System;

public class PressurePlate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        transform.DOMoveY(-0.5f, 0.7f, false);
        GameObject[] endObjects = GameObject.FindGameObjectsWithTag("end");
        foreach (GameObject endObject in endObjects)
        {
            endObject.SetActive(false);
        }
    }
}

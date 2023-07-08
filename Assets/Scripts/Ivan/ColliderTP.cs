using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTP : MonoBehaviour
{
    public GameObject go;
    public static bool canGoTrough = true;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "DumbAlly" && canGoTrough)
        {
            other.gameObject.transform.position = go.transform.position;
            canGoTrough = false;
            StartCoroutine(UpdateBoolean());
        }
    }

    IEnumerator UpdateBoolean()
    {
        yield return new WaitForSeconds(0.4f);
        canGoTrough = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ColliderArrow : MonoBehaviour
{
    public Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DumbAlly")
        {

            StartCoroutine(UpdateDirection(other));
           
        }
    }

    IEnumerator UpdateDirection(Collider other)
    {
        yield return new WaitForSeconds(.4f);
        other.gameObject.GetComponent<PlayerMovement>().direction = direction;
        other.gameObject.transform.DORotate(this.gameObject.transform.rotation.eulerAngles, 0.5f, RotateMode.Fast);
    }

}

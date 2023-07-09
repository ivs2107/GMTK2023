using UnityEngine;

public class SliderZ : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 startPosition;
    private Plane plane;

    private void Start()
    {
        plane = new Plane(Vector3.up, transform.position);
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            startPosition = transform.position;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "ProtectBlock")
        {
            isDragging = false;
        }
    }

    private void OnMouseUp()
    {
        if (isDragging)
        {
            isDragging = false;
        }
    }

    private void Update()
    {
        if (isDragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float distanceToPlane;

            if (plane.Raycast(ray, out distanceToPlane))
            {
                Vector3 hitPoint = ray.GetPoint(distanceToPlane);
                hitPoint.y = startPosition.y;
                hitPoint.x = startPosition.x;

                transform.position = hitPoint;
            }
        }
    }
}
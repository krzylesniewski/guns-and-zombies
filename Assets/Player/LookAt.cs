using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] Camera cam;

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = (Vector2)cam.ScreenToWorldPoint(Input.mousePosition);
        float angleRad = Mathf.Atan2
        (
            mousePosition.y - transform.position.y,
            mousePosition.x - transform.position.x
        );
        float angleDeg = (180 / Mathf.PI) * angleRad;

        transform.rotation = Quaternion.Euler(0f, 0f, angleDeg);
        Debug.DrawLine(transform.position, mousePosition, Color.red, Time.deltaTime);
    }
}

using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float cameraHeight;
    public float cameraDistance;
    public float cameraSpeed;

    public GameObject target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        Vector3 targetPosition = target.transform.position;

        targetPosition.y += cameraHeight;
        targetPosition.z -= cameraDistance;
        
        transform.position = Vector3.Lerp(transform.position, targetPosition, cameraSpeed * Time.deltaTime);
        
    }
}
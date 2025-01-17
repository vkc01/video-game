using UnityEngine;
using cardsetup;
using UnityEngine.InputSystem;

public class cardmovement : MonoBehaviour
{
    public float speed = 10;
    public float rotationSpeed = 180;
    public float verticalOffset = 0.5f;
    public float verticalSpeed = 1;
    public float verticalFrequency = 1;
    public float verticalAmplitude = 0.5f;
    private Vector3 targetPosition;
    private Quaternion targetRotation;
    private float verticalOffsetTime;
    private float verticalOffsetValue;
    void Start()
    {
        targetPosition = transform.position;
        targetRotation = transform.rotation;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        verticalOffsetTime += Time.deltaTime;
        verticalOffsetValue = Mathf.Sin(verticalOffsetTime * verticalFrequency) * verticalAmplitude;
        transform.position += Vector3.up * verticalOffsetValue * verticalSpeed * Time.deltaTime;
    }

    public void SetTargetPosition(Vector3 position)
    {
        targetPosition = position;
    }

    public void SetTargetRotation(Quaternion rotation)
    {
        targetRotation = rotation;
    }
}

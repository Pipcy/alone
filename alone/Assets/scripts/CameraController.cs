using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    public float minDistance = 20f;
    public float maxDistance = 50f;
    public float followSpeed = 10f; // added follow speed

    private float defaultSize;

    private void Start()
    {
        defaultSize = Camera.main.orthographicSize;
    }

    private void Update()
    {
        float distance = Vector3.Distance(player1.position, player2.position);
        //Debug.Log(distance);
        Vector3 midpoint = Vector3.Lerp(player1.position, player2.position, 0.5f);
        Vector3 newPosition = new Vector3(midpoint.x, midpoint.y, -20f);
        transform.position = Vector3.Lerp(transform.position, newPosition, followSpeed * Time.deltaTime);

        if (distance > minDistance)
        {
            //GameObject.enabled = false;
        }
        else if (distance > minDistance)
        {
            float newSize = distance / 2f;
            Camera.main.orthographicSize = Mathf.Clamp(newSize, minDistance, maxDistance);// make sure to tag "main camera"
        }
        else
        {
            Camera.main.orthographicSize = defaultSize;
        }
    }
}

using UnityEngine;

public class CameraController : MonoBehaviour
{
    //for overview camera
    public Transform player1;
    public Transform player2;
    public float minDistance =10f;
    public float maxDistance = 30f;
    public float followSpeed = 10f; // added follow speed
    private float defaultSize;

    //for basic camera switching
    public Camera player1Cam;
    public Camera player2Cam;
    public Camera overviewCam;

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

        ShowOverviewCam();
        if (distance > 40f)
        {
            ShowPlayerCam();
        }
        else if (distance > minDistance)
        {
            
            float newSize = distance / 2f;
            Camera.main.orthographicSize = Mathf.Clamp(newSize, minDistance, maxDistance);// make sure to tag "main camera"
    
        }
        else
        {
            Camera.main.orthographicSize = 8;
        }
    }

    public void ShowPlayerCam()
    {
        player1Cam.enabled = true;
        player2Cam.enabled = true;
        overviewCam.enabled = false;
    }
    
    public void ShowOverviewCam()
    {
        player1Cam.enabled = false;
        player2Cam.enabled = false;
        overviewCam.enabled = true;
    }
}

using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    private Camera mainCamera;

    //추적할 대상
    public Transform target;
    //카메라와의 거리   
    public float dist = 30f;

    //카메라 회전 속도
    public float xSpeed = 220.0f;
    public float ySpeed = 100.0f;

    //카메라 회전 민감도
    public float lookSensitivity = 0.015f;

    //카메라 초기 위치
    public float x = 0.0f;
    public float y = 0.0f;

    //y값 제한
    public float yMinLimit = -20f;
    public float yMaxLimit = 80f;

    //앵글의 최소,최대 제한
    float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }

    //줌인,줌아웃 스피드
    public float zoomSpeed = 10.0f;

    void Start()
    {
        mainCamera = GetComponent<Camera>();

        //커서 숨기기
        //Cursor.lockState = CursorLockMode.Locked;
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;
    }
    void Update()
    {
        if (target)
        {

            //카메라 회전속도 계산
            x += Input.GetAxis("Mouse X") * xSpeed * lookSensitivity;
            y -= Input.GetAxis("Mouse Y") * ySpeed * lookSensitivity;

            //앵글값 정하기
            //y값의 Min과 MaX 없애면 y값이 360도 계속 돎
            //x값은 계속 돌고 y값만 제한
            y = ClampAngle(y, yMinLimit, yMaxLimit);

            //카메라 위치 변화 계산
            Quaternion rotation = Quaternion.Euler(y, x, 0);
            Vector3 position = rotation * new Vector3(1, 10.0f, -dist) + target.position + new Vector3(0.0f, 0, 0.0f);

            transform.rotation = rotation;
            transform.position = position;
        }

        Zoom();

    }

    void Zoom()
    {
        float distance = Input.GetAxis("Mouse ScrollWheel") * -1 * zoomSpeed;
        if (distance != 0)
        {
            mainCamera.fieldOfView += distance;
        }
    }
}
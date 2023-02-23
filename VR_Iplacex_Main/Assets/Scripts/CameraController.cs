
using UnityEngine;





[RequireComponent(typeof(InputController))] 
public class CameraController : MonoBehaviour
{
    [SerializeField] float _mouseSensitivity =0f;
    [SerializeField] Transform _cameraAnchor = null;
    InputController _InputController = null;
    void Awake() // esperar para resivir el imput
    {
        _InputController = GetComponent<InputController>();

    }
    void Update(){
        MouseCamera();
    }
    void MouseCamera()
    {
        Vector2 input = _InputController.MouseInput();
        transform.Rotate(Vector3.up * input.x * _mouseSensitivity * Time.deltaTime);
        Vector3 angle = _cameraAnchor.eulerAngles;
        angle.x += input.y * _mouseSensitivity * Time.deltaTime;
        _cameraAnchor.eulerAngles =angle;
    }

}

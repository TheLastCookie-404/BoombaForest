using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController _characterController;
    private Vector3 _input;
    private float _playerSpeed = 10f;
    private float _playerRotSpeed = 10f;
    private float _horizontalInput;
    private float _verticalInput;
    private float _mouseXInput;
    private float _mouseYInput;

    void Start()
    {
        /*_characterController = gameObject.AddComponent<CharacterController>();*/
        _characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime * _playerSpeed;
        _verticalInput = Input.GetAxis("Vertical") * Time.deltaTime * _playerSpeed;
        _mouseXInput = Input.GetAxis("MouseX") * Time.deltaTime * _playerRotSpeed;
        _mouseYInput = Input.GetAxis("Mousey") * Time.deltaTime * _playerRotSpeed;

        transform.rotation =  Quaternion.Euler(_horizontalInput, _verticalInput, 0);
        _input.x = _horizontalInput;
        _input.z = _verticalInput;
        _characterController.Move(_input);
    }
}

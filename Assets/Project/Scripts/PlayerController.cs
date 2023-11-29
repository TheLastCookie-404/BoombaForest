using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController _characterController;
    private Vector3 _input;
    private float _playerSpeed = 30;
    private float horizontalInput;
    private float verticalInput;
    void Start()
    {
        _characterController = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime * _playerSpeed;
        verticalInput = Input.GetAxis("vertical") * Time.deltaTime * _playerSpeed;
        _input.x = horizontalInput;
        _input.y = verticalInput;
        _characterController.Move(_input);
    }
}

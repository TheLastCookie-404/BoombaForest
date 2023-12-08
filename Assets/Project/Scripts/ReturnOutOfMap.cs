using UnityEngine;

public class ReturnOutOfMap : MonoBehaviour
{
    private Vector3 _defaultPos;
    private void Start() => _defaultPos = new Vector3(-128f, 11f, 3.41f);

    private void Update()
    {
        if(transform.position.y < -70) transform.position = _defaultPos;
    }
}

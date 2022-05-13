using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    private Vector3 _offset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        var input = Input.GetAxis("Horizontal");
        transform.position = _player.transform.position + _offset;
    }
}

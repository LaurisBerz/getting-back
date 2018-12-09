using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTopDownController : MonoBehaviour {

    [SerializeField]
    private Transform target;
    [SerializeField]
    private Vector3 offset;
    [SerializeField]
    private float cameraZoom = 10f;

	void Update () {
        transform.position = target.position - offset * cameraZoom;
        transform.LookAt(target.position, Vector3.up);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

/// <summary>
/// Die Klasse steuert die Cameraführung
/// </summary>
public class CameraHandler : MonoBehaviour
{
    /// <summary>
    /// Zeiger auf die virtuelle Kamera
    /// </summary>
    [SerializeField] private CinemachineVirtualCamera cinemachineVirtualCamera;

    /// <summary>
    /// Feld für die Orthographische Größe der Virtuellen Kamera
    /// </summary>
    private float orthographicSize;
    private float targetOrthographicSize;

    private void Start()
    {
        orthographicSize = cinemachineVirtualCamera.m_Lens.OrthographicSize;
        targetOrthographicSize = orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        HandleZoom();
    }

    /// <summary>
    /// Steuert die Kamerabewegung
    /// </summary>
    private void HandleMovement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 moveDir = new Vector3(x, y).normalized;
        float moveSpeed = 30f;

        transform.position += moveDir * moveSpeed * Time.deltaTime;
    }

    /// <summary>
    /// Steuert den Zoom der Kamera
    /// </summary>
    private void HandleZoom()
    {
        float zoomAmount = 2f;
        targetOrthographicSize += -Input.mouseScrollDelta.y * zoomAmount;

        float minOrthographicSize = 10f;
        float maxOrthographicSize = 30f;
        targetOrthographicSize = Mathf.Clamp(targetOrthographicSize, minOrthographicSize, maxOrthographicSize);

        float zoomSpeed = 5f;
        orthographicSize = Mathf.Lerp(orthographicSize,
            targetOrthographicSize, Time.deltaTime * zoomSpeed);

        cinemachineVirtualCamera.m_Lens.OrthographicSize = orthographicSize;
    }
}

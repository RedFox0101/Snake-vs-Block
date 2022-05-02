using UnityEngine;

public class CameraResolution : MonoBehaviour
{
    [Range(0f, 1f)]
    [SerializeField] private float _widthOrHeight = 0;
    [SerializeField] Vector2 _refaultResolution = new Vector2(720, 1280);

    private Camera _componentCamera;
    private float _initialSize;
    private float _targetAspect;

    private void Awake()
    {
        _componentCamera = GetComponent<Camera>();

        _initialSize = _componentCamera.orthographicSize;

        _targetAspect = _refaultResolution.x / _refaultResolution.y;

        float constantWidthSize = _initialSize * (_targetAspect / _componentCamera.aspect);

        _componentCamera.orthographicSize = Mathf.Lerp(_initialSize, constantWidthSize, _widthOrHeight);
    }
}

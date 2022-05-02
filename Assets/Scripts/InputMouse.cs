using UnityEngine;

public class InputMouse : MonoBehaviour
{
    private Camera _camera;
   
    private void Awake()
    {
        _camera = Camera.main;
    }

    public Vector2 GetDirectionToClick(Vector2 headPosition)
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = _camera.ScreenToViewportPoint(mousePosition);
        mousePosition.y = 1;
        mousePosition = _camera.ViewportToWorldPoint(mousePosition);

        return new Vector2((mousePosition.x - headPosition.x) * 7, mousePosition.y - headPosition.y);


    }
}

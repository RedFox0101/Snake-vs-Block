using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
public class Block : MonoBehaviour
{
    [SerializeField] private Vector2Int _destroyPriceRange;
    [SerializeField] private Color[] _colors;

    private int _destroyPrice;
    private SpriteRenderer _spriteRenderer;

    public UnityAction<int> FillingUpdate;

    private void Start()
    {
      _spriteRenderer= GetComponent<SpriteRenderer>();
         SetColor(_colors[Random.Range(0, _colors.Length)]);
        _destroyPrice = Random.Range(_destroyPriceRange.x, _destroyPriceRange.y);
        FillingUpdate?.Invoke(_destroyPrice);
    }

    public void Fill()
    {  
        _destroyPrice--;
        FillingUpdate?.Invoke(_destroyPrice);
        if (_destroyPrice==0) Destroy(gameObject);
    }

    private void SetColor(Color color)
    {
        _spriteRenderer.color = color;
    }
}

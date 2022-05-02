using UnityEngine;
using TMPro;

[RequireComponent(typeof(SpriteRenderer))]
public class BlockView : MonoBehaviour
{
    [SerializeField] private Block _block;
    [SerializeField] private TMP_Text _text;

    private void OnEnable()
    {
        _block.FillingUpdate += UpdateText;
    }

    private void OnDisable()
    {
        _block.FillingUpdate -= UpdateText;
    }

    private void UpdateText(int value)
    {
        _text.text = value.ToString();
    }

  
}

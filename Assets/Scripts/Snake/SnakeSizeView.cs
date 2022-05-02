using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

[RequireComponent(typeof(Snake))]
public class SnakeSizeView : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    private Snake _snake;
    private void OnEnable()
    {
        _snake.SizeUpdated += UpdateSizeText;
    }

    private void UpdateSizeText(int size)
    {
        _text.text = size.ToString();
    }

    private void OnDisable()
    {
        
    }

    private void Awake()
    {
        _snake = GetComponent<Snake>();
    }
}

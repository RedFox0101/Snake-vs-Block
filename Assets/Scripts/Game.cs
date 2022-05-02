using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [SerializeField] private Snake _snake;

    private void OnEnable()
    {
        _snake.EmptySnake += OnDead;
    }
    private void OnDisable()
    {
        _snake.EmptySnake -= OnDead;
    }
    private void OnDead()
    {
        SceneManager.LoadScene(0);
    }


}

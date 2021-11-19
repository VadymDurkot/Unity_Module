using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{

    public float playerVelocity;
    private Vector3 playerPosition;

    // используйте этот метод для инициализации
    void Start()
    {
        // получим начальную позицию платформы
        playerPosition = gameObject.transform.position;
    }

    // Update вызывается при отрисовке каждого кадра игры
    void Update()
    {
        // горизонтальное движение
        playerPosition.x += Input.GetAxis("Horizontal") * playerVelocity;

        // выход из игры
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        // обновим позицию платформы
        transform.position = playerPosition;
    }
}
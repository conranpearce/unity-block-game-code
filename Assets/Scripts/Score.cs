using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public PlayerMovement movement;

    void Update()
    {
        if (player.position.z >= 0 && player.position.z < 150)
        {
            scoreText.text = player.position.z.ToString("0");
        }
        else if (player.position.z < 0)
        {
            scoreText.text = "0";
        }
        else if (player.position.z >= 150)
        {
            if (player.position.z >= 200)
            {
                FindObjectOfType<GameManager>().EndGame();

            } else
            {
                scoreText.text = "150";
                movement.controls = false;
            }
        }
    }
   
}

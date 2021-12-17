using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth1, playerHealth2;
	public float restartDelay = 5f;


    Animator anim;
	float restartTimer;


    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playerHealth1.currentHealth <= 0 && playerHealth2.currentHealth<=0)
        {
            anim.SetTrigger("GameOver");

			restartTimer += Time.deltaTime;

			if (restartTimer >= restartDelay) {
				Application.LoadLevel(Application.loadedLevel);
			}
        }
    }
}

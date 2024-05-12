using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToPurgatory : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CatWithGruz cat = collision.GetComponent<CatWithGruz>();
        if (cat != null)
        {
            int index = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(index + 1);
            Time.timeScale = 1.0f;
        }

    }
}

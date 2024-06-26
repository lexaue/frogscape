using UnityEngine;

public class Home : MonoBehaviour
{

    public GameObject frog;


    private void OnEnable()
    {
        frog.SetActive(true);
    }

    private void OnDesable()
    {
        frog.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            enabled = true;

            Frogscape frogscape = other.GetComponent<Frogscape>();
            frogscape.Respawn();
        }
    }
}

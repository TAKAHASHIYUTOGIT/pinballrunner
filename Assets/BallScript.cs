using UnityEngine;

public class BallScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "Road")
        {
            Destroy(gameObject, 0.1f);
        }
    }
}


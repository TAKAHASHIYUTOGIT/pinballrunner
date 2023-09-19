using UnityEngine;

public class BallScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Road")
        {
            Destroy(this.gameObject, 0.1f);
        }
        if(collision.gameObject.name == "Player")
        {
            Destroy(this.gameObject, 0.1f);
        }
    }
}


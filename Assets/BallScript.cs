using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallScript : MonoBehaviour
{   
    // Start is called before the first frame update
    void Start()
    {
         
    }

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "Road")
        {
            // 0.2秒後に消える
            Destroy(gameObject, 0.2f);
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    [SerializeField] Text _resaltText;

    void Start()
    {

    }

    void Update()
    {
        _resaltText.text = "ÉXÉRÉA:" + Point._score.ToString("D2");
        
    }
}

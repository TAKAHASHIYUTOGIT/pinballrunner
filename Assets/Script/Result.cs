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
        _resaltText.text = "�X�R�A:" + Point._score.ToString("D2");
        
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Text _text;
    public static float _timer;
    [SerializeField] float _gameOverTime = 60f;

    void Start()
    {
        _timer = _gameOverTime;
    }

    void Update()
    {
        if (_timer <= 0)
        {
            SceneManager.LoadScene("Result");
        }
        else
        {
            _timer -= Time.deltaTime;
            _text.text = "���ԁF" + _timer.ToString("f2");
            //�����_�ȉ���Q�ʂ܂ŕ\��
        }
    }
}

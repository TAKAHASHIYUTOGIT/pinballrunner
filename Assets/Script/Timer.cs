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
            _text.text = "時間：" + _timer.ToString("f2");
            //小数点以下第２位まで表示
        }
    }
}

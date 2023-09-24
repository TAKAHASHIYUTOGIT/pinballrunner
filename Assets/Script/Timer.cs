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
        _timer = 0;
    }

    void Update()
    {
        if (_timer > _gameOverTime)
        {
            SceneManager.LoadScene("Result");
        }
        else
        {
            _timer += Time.deltaTime;
            _text.text = _timer.ToString("f2");
        }
    }
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public float countdownTime = 545f; // Время в секундах для обратного отсчета
    private bool isRunning = false; // Флаг для проверки, запущен ли таймер

    public TextMeshProUGUI timerText; // Ссылка на компонент текста, используемого для отображения таймера

    void Start()
    {
        // Запустить таймер
        StartTimer();
    }

    void Update()
    {
        // Проверить, закончился ли таймер
        if (countdownTime <= 0f)
        {
            Debug.Log("Время истекло!");
            StopTimer();
        }
    }

    // Функция для запуска таймера
    public void StartTimer()
    {
        if (!isRunning)
        {
            isRunning = true;
            StartCoroutine(Countdown());
        }
    }

    // Функция для остановки таймера
    public void StopTimer()
    {
        if (isRunning)
        {
            isRunning = false;
            StopCoroutine(Countdown());
        }
    }

    // Корутина для отсчета времени вниз
    private IEnumerator Countdown()
    {
        while (countdownTime > 0f)
        {
            yield return new WaitForSeconds(1f); // Ждать 1 секунду
            countdownTime--;
            UpdateTimerText(); // Обновить текстовый компонент
        }
    }

    // Функция для обновления текстового компонента с отображением таймера
    private void UpdateTimerText()
    {
        if (timerText != null)
        {
            string minutes = Mathf.Floor(countdownTime / 60).ToString("00");
            string seconds = (countdownTime % 60).ToString("00");

            timerText.text = minutes + ":" + seconds;
        }
    }
}
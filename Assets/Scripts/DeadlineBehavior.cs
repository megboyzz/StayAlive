using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  Класс для представления линии за байком
/// </summary>
public class DeadlineBehavior : MonoBehaviour {
    
    /// <summary>
    ///  Объект линии
    /// </summary>
    public GameObject deadline;
    
    /// <summary>
    ///  Ссылка на байк
    /// </summary>
    public GameObject motobike;
    
    private float timer = 0f;
    private float eventFrequency = 2f; // Частота события в секундах
    
    /// <summary>
    ///  Метод тика который вызвается каждый тик
    /// в нем создается линия 
    /// </summary>
    private void Update()
    {
        
    }

    private void Start()
    {
        
    }
    
    
    /// <summary>
    ///  Метод представляющий событие касание линии инородным объектом
    /// </summary>
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Меня тронули! " + other.tag);
    }
}

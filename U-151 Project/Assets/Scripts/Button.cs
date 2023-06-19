using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField]
    int task;
    public void Button_interaction()
    {
        switch (task)
        {
            case 1:
                task1();
                break;
            case 2:
                task2();
                break;
            default:
                break;
        }
    }
    void task1() {
        Debug.Log("Task1 launched");
    }
    void task2() {
        Debug.Log("Task2 launched");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //ENCAPSULATION
    public static GameManager Instance { get; private set; }
    public int chosenCar { get; private set; }
    private void Awake()
    {
        //ABSTRACTION
        Singleton();
        DontDestroyOnLoad(gameObject);
    }

    private void Singleton()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartGame(int carChoice)
    {
        AssignCar(carChoice);
        SceneManager.LoadScene(1);
    }

    private void AssignCar(int carChoice)
    {
        chosenCar = carChoice;
    }
}

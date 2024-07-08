using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuChucNang : MonoBehaviour
{
    [Header("Menu Button")]

    [SerializeField] private Button newGameButton;

    [SerializeField] private Button loadGameButton;
    public void ChoiMoi()
    {

        DisableMenuButton();
        DataPersistenceManager.instance.NewGame();

        SceneManager.LoadSceneAsync("Game");


    }

    public void ChoiTiep()
    {
        DisableMenuButton();
        SceneManager.LoadSceneAsync("Game");
    }

    public void Thoat()
    {
        Application.Quit();
    }

    private void DisableMenuButton()
    {
        newGameButton.interactable = false;
        loadGameButton.interactable = false;
    }
}

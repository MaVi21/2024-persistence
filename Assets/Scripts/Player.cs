using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public string sceneToLoad;
    private Text nameText;
    private Text moneyText;
    
    void Start()
    {
        nameText = GameObject.Find("SceneNameText").GetComponent<Text>();
        nameText.text = "Scene " + SceneManager.GetActiveScene().name;

        Debug.Log("Scene " + SceneManager.GetActiveScene().name + " loaded");
        Debug.Log("Player's money: " + PlayerInfo.Money);

        moneyText = GameObject.Find("MoneyText").GetComponent<Text>();
        moneyText.text = "Player's money: " + PlayerInfo.Money;

        GameObject.Find("MoneyButton").GetComponent<Button>().onClick.AddListener(() => OnMoneyButtonClicked());
        GameObject.Find("SceneButton").GetComponent<Button>().onClick.AddListener(() => OnSceneButtonClicked());
    }

    public void OnMoneyButtonClicked()
    {
        PlayerInfo.Money++;
        Debug.Log("Money updated to: " + PlayerInfo.Money);
        moneyText.text = "Player's money: " + PlayerInfo.Money;
    }

    public void OnSceneButtonClicked()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}

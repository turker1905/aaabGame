using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool _gameHasEnded = false;

    //public Animator _anim;
    public Rotater _rotater;
    [SerializeField] Text _endGameText;

    public Pin _pin;

    public void EndGame()
    {
        if (_gameHasEnded)
            return;
       _rotater.enabled = false;
        _pin.enabled = false;
        _endGameText.text = "Game Over";

        //_anim.SetTrigger("EndGame");
        _gameHasEnded = true;
       

    }


    public void RestartLewel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    }

}

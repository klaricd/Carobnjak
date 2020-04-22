using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Carobnjak : MonoBehaviour
{

    int max;
    int min;
    int pokusaj;
    int maxBrojPokusaja = 10;

    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();        
    }

    void StartGame()
    {
        max = 1001;
        min = 1;
        SljedeciPokusaj();
    }

    public void PokusajManji()
    {
        max = pokusaj;
        SljedeciPokusaj();
    }

    public void PokusajVeci()
    {
        min = pokusaj;
        SljedeciPokusaj();
    }

    void SljedeciPokusaj()
    {
        pokusaj = Random.Range(min, max + 1);
        text.text = pokusaj.ToString();
        maxBrojPokusaja = maxBrojPokusaja - 1;
        if(maxBrojPokusaja <= 0)
        {
            SceneManager.LoadScene("Win Screen");
        }
    }
}

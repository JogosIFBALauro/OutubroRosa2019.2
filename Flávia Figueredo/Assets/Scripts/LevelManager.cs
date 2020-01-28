using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public int food;
    public int foodPontos;

    public Text foodContar;
    public Text foodPontosContar;
    

    /*public int exercise;
    public int exercisePontos;

    public Text exerciseContar;
    public Text exercisePontosContar;*/


    private void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        foodContar.text = food.ToString();
        foodPontosContar.text = foodPontos.ToString();

        /*exerciseContar.text = exercise.ToString();
        exercisePontosContar.text = exercisePontos.ToString();*/
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Scoremanager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private float score;
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }
    }
}

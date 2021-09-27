using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //List of Game Objects called targets, we will set list size in Unity Inspector drag-doping the Game Objects 
    public List<GameObject> targets;

    public TextMeshProUGUI scoreText;
    private int score;

    private float spawnRate = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());

        score = 0;
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }

        
    }
}

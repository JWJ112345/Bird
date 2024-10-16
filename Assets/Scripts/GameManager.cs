using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    static public GameManager Instance;    

    public GameObject wallPrefab;
    public float spawnTerm = 2;

    public TextMeshProUGUI scoreLabel;

    public float score;

    float spawnTimer;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = 0;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * 100f;
        scoreLabel.text = ((int)score).ToString();

        spawnTimer += Time.deltaTime;

        if (spawnTimer > spawnTerm)
        {
            spawnTimer -= spawnTerm;

            GameObject obj = Instantiate(wallPrefab);
            obj.transform.position = new Vector2(14, Random.Range(-3.75f, 1.75f));

        }

    }


}

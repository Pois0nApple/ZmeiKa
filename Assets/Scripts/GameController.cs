using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{

    public Transform Player;
    public Level[] LevelPref;
    public Level FerstLevel;
    
    private List<Level>spawnedLevels = new List<Level>();

    private void Start()
    {
        spawnedLevels.Add(FerstLevel);
    }

    private void Update()
    {
        if (GameObject.FindWithTag("SnakeHead") != null)
        {
            if (Player.position.z > spawnedLevels[spawnedLevels.Count - 1].End.position.z - 60)
            {

                SpawnLevel();

            }
        }
    }

    private void SpawnLevel ()
    {
        Level newLevel = Instantiate(LevelPref[Random.Range(0, LevelPref.Length)]);
        newLevel.transform.position = spawnedLevels[spawnedLevels.Count-1].End.position - newLevel.Begin.position;
        spawnedLevels.Add(newLevel);

        if (spawnedLevels.Count>=3)
        {
            Destroy(spawnedLevels[0].gameObject);
            spawnedLevels.RemoveAt(0);
        }
    }


}

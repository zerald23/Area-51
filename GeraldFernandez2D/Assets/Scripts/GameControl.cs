using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

   public enum LevelObjective {
        Collect,
        Destroy,
        Reachpoint
    }

    public LevelObjective levelObjective;
    public int objetiveCount;

    public List<MonoBehaviour> 

    void Start() {
        Init();
    }

    void Init()
    {
        if (levelObjective == LevelObjective.Collect)
        {
            // UI Display of Collect items Left	
        }
    }
    public void RestarLevel()
    {
        SwitchScene(SceneManager.GetActiveScene().name);
    }

    public void NextLevel() {
        SwitchScene(null);
    }
    void SwitchScene (string)
using UnityEngine;

public class NestedPipeScript : MonoBehaviour
{
    private ScoringScript scoringSystem;

    void Start(){
        scoringSystem = GameObject.FindGameObjectWithTag("ScoreSystem").GetComponent<ScoringScript>();
    }
    void OnCollisionEnter2D(Collision2D collision){
        scoringSystem.GameOver();
    }
}

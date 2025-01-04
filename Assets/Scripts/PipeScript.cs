using UnityEngine;

public class PipeScript : MonoBehaviour
{
    [SerializeField] private const float moveSpeed = 3f;
    private ScoringScript scoringSystem;

    void Start(){
        scoringSystem = GameObject.FindGameObjectWithTag("ScoreSystem").GetComponent<ScoringScript>();
    }

    void OnTriggerExit2D(Collider2D collision){
        if(collision.gameObject.tag == "Player"){
            scoringSystem.AddScore(1);
        }
    }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < -10f){
            Destroy(gameObject);
        }
    }
}

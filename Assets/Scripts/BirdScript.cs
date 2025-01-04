using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    [SerializeField] ScoringScript scoreScript;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !scoreScript.isGameOver){
            rigidBody.linearVelocity = Vector2.up * 10;
        }
    }
}

using UnityEngine;

public class PipeRenderScript : MonoBehaviour
{
    [SerializeField] private GameObject pipeRenderer;
    private const float offSet = 3f;

    void Start()
    {
        InvokeRepeating("spawnPipe", 0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnPipe(){
        Instantiate(pipeRenderer, new Vector3(transform.position.x, Random.Range(-offSet, offSet), transform.position.z), Quaternion.identity);
    }
}

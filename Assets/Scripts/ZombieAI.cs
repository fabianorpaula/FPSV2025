using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    private Animator animator;
    private Transform player;
    public float detectionRange = 10f;
    public float attackRange = 2f;
    public ZombieState currentState;
    public GameObject personagem;
    
    void Start()
    {
        personagem = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Seguir();
    }


    void Seguir()
    {

        Vector3 vetorCorrigido = new Vector3(
            personagem.transform.position.x,
            transform.position,
            personagem.transform.position.z);

        transform.position = Vector3.MoveTowards(
            transform.position,
            vetorCorrigido,
            0.01f);
    }
}

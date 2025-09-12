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
        animator = GetComponent<Animator>();
        personagem = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Presenca();
        if (currentState == ZombieState.Walking)
        {
            Seguir();
        }
    }

    void Presenca()
    {
        //Calcula a Distancia Entre Zumbi e Personagem
        float distanciaPersonagem = Vector3.Distance(
            personagem.transform.position,
            transform.position);
        if (distanciaPersonagem < 10)
        {
            currentState = ZombieState.Walking;
            animator.SetBool("walk", true);
        }
        if(distanciaPersonagem > 20)
        {
            currentState = ZombieState.Idle;
            animator.SetBool("walk", false);
        }
    }


    void Seguir()
    {

        Vector3 vetorCorrigido = new Vector3(
            personagem.transform.position.x,
            transform.position.y,
            personagem.transform.position.z);

        transform.position = Vector3.MoveTowards(
            transform.position,
            vetorCorrigido,
            0.01f);

        transform.LookAt(vetorCorrigido);
    }
}

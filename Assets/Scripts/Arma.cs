using UnityEngine;

public class Arma : MonoBehaviour
{
    //Objeto que vou Atirar
    public GameObject projetil;
    public GameObject pontoSaida;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Disparo();
        }
    }
    void Disparo()
    {
        //Crio o Projetil
        GameObject Tiro = Instantiate(projetil, 
            pontoSaida.transform.position, 
            Quaternion.identity);
        //Dou Velociado ao Projetil
        Tiro.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
        Destroy(Tiro, 1f);
    }


}

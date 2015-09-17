using UnityEngine;
using System.Collections;

public class cambiarescena : MonoBehaviour {

	//funcion escena
	public void Cambiar(int indice)
	{
		Application.LoadLevel(indice);
	}

}

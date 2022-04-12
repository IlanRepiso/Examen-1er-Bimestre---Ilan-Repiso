using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text1 : MonoBehaviour
{
    public int DiasTotales;
    public int DiasLluvia;
    public int CantDeUnidades;

    // Start is called before the first frame update
    void Start()
    {
        if (DiasTotales < 5 || DiasLluvia < 0 || DiasLluvia > DiasTotales)
        {
            Debug.Log("Error 404. Syntax Error");
        }
        else
        {
            int DiasNoLluvia = DiasTotales - DiasLluvia;
            int LitroCombustible = (DiasLluvia * 8) + (DiasNoLluvia * 6);
            int PrecioCombustible = LitroCombustible * 130 * CantDeUnidades;
            Debug.Log("Una flota de "+ CantDeUnidades +" unidades trabajando durante "+ DiasTotales +" días implicará un gasto de "+ PrecioCombustible +" pesos en concepto de combustible");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

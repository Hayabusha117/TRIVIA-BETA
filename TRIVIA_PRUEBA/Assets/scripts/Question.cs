using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour //esta si desciende de monohavior porque lo vamosa agregar a un game object
{
    public string text = null; //texto de la pregunta
    public List<Option> options = null; //lista donde se almacenan las opciones y el option es el nombre del otro archivo

}

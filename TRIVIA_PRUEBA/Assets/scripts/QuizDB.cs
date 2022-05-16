using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//lista en la que se almacenan todas las preguntas que vamos a utilizar
public class QuizDB : MonoBehaviour
{
    [SerializeField] private List<Question> m_questionList = null;

    private List<Question> m_backup = null; // para tener un respaldo de las preguntas 

   
    private void Awake()
    {
        m_backup = m_questionList.ToList();
    }
    
    
    
    //para ir removiendo la pregunta que se hizo y asi no se repita 
    public Question GetRandom(bool remove= true)
    {

        if (m_questionList.Count == 0)
            RestoreBackup();
            

        int index = Random.Range(0, m_questionList.Count);

        if (!remove)
            return m_questionList[index];

        Question q = m_questionList[index];
        m_questionList.RemoveAt(index);

        return q;
    }

    private void RestoreBackup()
    {
        m_questionList = m_backup.ToList();
    }
}

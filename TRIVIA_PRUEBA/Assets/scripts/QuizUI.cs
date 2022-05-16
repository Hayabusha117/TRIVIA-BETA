using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class QuizUI : MonoBehaviour
{
    [SerializeField] private Text m_question = null;
    [SerializeField] private List<OptionButton> m_buttonList = null;

    public void Construtc(Question q, Action<OptionButton> callback )
    {
        m_question.text = q.text;

        //inicializar los botones, contruye los botoenes con cada opcion de la pregunta
        for (int n = 0; n<m_buttonList.Count; n++)
        {
            m_buttonList[n].Construtc(q.options[n], callback);
        }
    }
}

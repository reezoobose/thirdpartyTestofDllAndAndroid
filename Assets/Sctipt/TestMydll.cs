using System;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class TestMydll : MonoBehaviour
{

    [DllImport("thirdpartycpluscplus",CallingConvention = CallingConvention.Cdecl ) ]
    private static extern int multiply(int a , int b);
    
    
    [DllImport("thirdpartycpluscplus",CallingConvention = CallingConvention.Cdecl ) ]
    private static extern int add(int a , int b);
    

    
    
    [SerializeField]
    private Text inputOne;
    [SerializeField]
    private Text inputTwo;
    [SerializeField]
    private Button addNumber;
    [SerializeField]
    private Button multiplyNumber;
    [SerializeField]
    private Text outPut;
    

    private void Start()
    {

        multiplyNumber.onClick.AddListener(() =>
        {

            outPut.text = multiply(  int.Parse( inputOne.text),  int.Parse(inputTwo.text)).ToString();
        });
        addNumber.onClick.AddListener(() =>
        {

            outPut.text = add(  int.Parse( inputOne.text),  int.Parse(inputTwo.text)).ToString();
        });
    }
}

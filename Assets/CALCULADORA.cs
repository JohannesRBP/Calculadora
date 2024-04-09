using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CALCULADORA : MonoBehaviour
{
   public Text resultado;
   public Text memoriaIndicador;
   public float num1 = 0f;
   public float num2 = 0f;
   public string operacion; 
   public float memoria = 0f; // Variable para almacenar el valor en memoria
   private List<float> numeros = new List<float>();
   private List<string> operaciones = new List<string>();
   public bool reset = false;


   public void Start() {
    verificarMemoria();
   }
    public void suma()
    {
        num1 = float.Parse(resultado.text);
        operacion = ("+");
        resultado.text = "";
        numeros.Add(num1);
        operaciones.Add(operacion);
    }

    public void resta()
    {
        num1 = float.Parse(resultado.text);
        operacion = ("-");
        resultado.text = "";
        numeros.Add(num1);
        operaciones.Add(operacion);
    }

    public void divison()
    {
        num1 = float.Parse(resultado.text);
        operacion = ("÷");
        resultado.text = "";
        numeros.Add(num1);
        operaciones.Add(operacion);
    }

    public void mult()
    {
        num1 = float.Parse(resultado.text);
        operacion = ("x");
        resultado.text = "";
        numeros.Add(num1);
        operaciones.Add(operacion);
    }

    public void digito7(){
        if(reset){
        resultado.text = "";
        reset = false;
        }   

        if(resultado.text == "0"){
            resultado.text = "7";
        }else{
            resultado.text = resultado.text + "7";
        }
        }
    
    public void digito8(){
        if(reset){
        resultado.text = "";
        reset = false;
        }   

        if(resultado.text == "0"){
            resultado.text = "8";
        }else{
            resultado.text = resultado.text + "8";
        }
        
        }

    public void digito9(){
        if(reset){
        resultado.text = "";
        reset = false;
        }   

        if(resultado.text == "0"){
            resultado.text = "9";
        }else{
            resultado.text = resultado.text + "9";
        }
        }
    public void digito4(){
        if(reset){
        resultado.text = "";
        reset = false;
        }   

          if(resultado.text == "0"){
            resultado.text = "4";
        }else{
            resultado.text = resultado.text + "4";
        }
        }

    public void digito5(){
        if(reset){
        resultado.text = "";
        reset = false;
        }   

        if(resultado.text == "0"){
            resultado.text = "5";
        }else{
            resultado.text = resultado.text + "5";
        }
        }
    public void digito6(){
        if(reset){
        resultado.text = "";
        reset = false;
        }   

          if(resultado.text == "0"){
            resultado.text = "6";
        }else if(resultado.text !="0"){
            resultado.text = resultado.text + "6";
        }else{
             resultado.text = "0";
        }
        }
    public void digito1(){
        if(reset){
        resultado.text = "";
        reset = false;
        }   

        if(resultado.text == "0"){
            resultado.text = "1";
        }else{
            resultado.text = resultado.text + "1";
        }
        }

    public void digito2(){
        if(reset){
        resultado.text = "";
        reset = false;
        }   
        if(resultado.text == "0"){
            resultado.text = "2";
            
        }else{
            resultado.text = resultado.text + "2";
        }
        }

    public void digito3(){
        if(reset){
        resultado.text = "";
        reset = false;
        }   
        if(resultado.text == "0"){
            resultado.text = "3";
        }else{
            resultado.text = resultado.text + "3";
        }
        }
        
    public void digito0(){
        if(resultado.text == "0"){
        resultado.text = "0";
        }else{
         resultado.text = resultado.text + "0";
         }
  
        }

public void igual(){ 
    num2 = float.Parse(resultado.text);
    numeros.Add(num2);

        float resultadoFinal = numeros[0];
        for (int i = 0; i < operaciones.Count; i++)
        {
            
            switch (operaciones[i])
            {
                case "+":
                    resultadoFinal += numeros[i + 1];

                    break;
                case "-":
                    resultadoFinal -= numeros[i + 1];
                    break;
                case "x":
                    resultadoFinal *= numeros[i + 1];
                    break;
                case "÷":
                    if (numeros[i + 1] != 0)
                        resultadoFinal /= numeros[i + 1];
                    else
                    {
                        resultado.text = "ERROR";
                        return;
                    }
                    break;
            }
            
            memoria = resultadoFinal;
          

        }

        resultado.text = resultadoFinal.ToString();
        verificarMemoria();
        
        numeros.Clear();
        operaciones.Clear();
        reset = true;
        
        
}

public void mplus() {

    float valorActual = float.Parse(resultado.text);
    memoria += valorActual;
    resultado.text = memoria.ToString();
    operacion = string.Empty;
    verificarMemoria();
 
  
}
public void mminus() {
    float valorActual = float.Parse(resultado.text);
    memoria -= valorActual;
    resultado.text = memoria.ToString();
    operacion = string.Empty;
    verificarMemoria();
    
}
public void mc(){
    memoria = 0f;
    resultado.text = "0";
    verificarMemoria();
  
}
public void mr(){
   resultado.text = memoria.ToString();
   verificarMemoria();
 
}


public void clear(){
    resultado.text = "0";
    operacion = string.Empty;
    numeros.Clear();
    operaciones.Clear();
    verificarMemoria();
}

public void delete(){
    if (resultado.text.Length > 1) {

        resultado.text = resultado.text.Substring(0, resultado.text.Length - 1);
    } else {
        resultado.text = "0";
    }
}
public void cambiarSigno(){
    float q = float.Parse(resultado.text);
    resultado.text = (-1*q).ToString();
}
public void puntoDecimal(){
    if(!resultado.text.Contains(".")){
        resultado.text = resultado.text + ",";
    }
}
public void verificarMemoria(){
    if (memoria != 0f)
        {
            memoriaIndicador.color = Color.green;
        }
        else
        {
            memoriaIndicador.color = Color.red;
        }
       
   }

}
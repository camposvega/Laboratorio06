/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejercicio.pkg5;

import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author Pc-pc
 */
public class Ejercicio5 {

    /**
     * @param args the command line arguments
     */
    
    public static void guardarVocales(ArrayList arr, String cadena){
        
        String letra = cadena.substring(0, 1);
        if(letra.equals("a") || letra.equals("e") || letra.equals("i") || letra.equals("o") || letra.equals("u") ||
                letra.equals("A") || letra.equals("I") || letra.equals("E") || letra.equals("O") || letra.equals("U") ){
            arr.add(0,letra);
        }
        
        if(cadena.length() == 1 || cadena.length() == 0);
        else {
            guardarVocales(arr,cadena.substring(1, cadena.length()));
        }
    }
    
    public static void main(String[] args) {
        // Realiza un programa que reciba n letras por 
        //teclado y almacene en una lista solo las vocales, mayúsculas o minúsculas
        ArrayList<String> lista = new ArrayList<String>();
        System.out.println("Ingrese cualquier texto!");
        Scanner sc = new Scanner(System.in);
        String cadena = sc.nextLine();
        
        guardarVocales(lista, cadena);
        
        
    }
    
}

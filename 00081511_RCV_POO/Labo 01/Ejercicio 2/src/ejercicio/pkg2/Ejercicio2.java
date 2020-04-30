/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejercicio.pkg2;

/**
 *
 * @author Pc-pc
 */
public class Ejercicio2 {

    /**
     * @param args the command line arguments
     */
    
    // Realiza una función que determine si una frase es palindrome o no e imprima el valor de verdad
    
    //Recursiva
    public static boolean fncPalindromo(String palabra){
        if(palabra.length() == 0 || palabra.length() == 1){
            return true;
        }
        if(palabra.charAt(0) == palabra.charAt(palabra.length() - 1)){
            return fncPalindromo(palabra.substring(1, palabra.length()-1));
        }else{
            return false;
        }
    }
    
    //iteracion
    public static boolean fncPalindromoI(String palabra){
        for(int i = 0; i<palabra.length(); i++){
            if(palabra.charAt(i) != palabra.charAt(palabra.length() - i - 1)){
                return false;
            }
        }
        return true;
    }
    
    
    public static void main(String[] args) {
        
        System.out.println(fncPalindromo("malayalam"));
        System.out.println(fncPalindromoI("malayalam"));
        //fncPalindromo("ana", 3);
        
    }
}

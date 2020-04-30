/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejercicio.pkg01;

/**
 *
 * @author Pc-pc
 */
public class Ejercicio01 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // Realiza un programa que a través de un solo for imprima los primeros n términos de fibonacci.
        
        //terminos de la serie que deseamos imprimir.
        int n = 8;
        
        //primeros dos terminos de la serie
        int a = 1;
        int b = 1;
        
        //valor de apoyo
        int c = 0;
        
        //ciclo para  imprimir n terminos
        for(int i = 0;i<n;i++){
            if(i == 0 || i == 1){
                System.out.println(a);
            }else{
                System.out.println(a + b);
                c = a;
                a = b;
                b = c + b;
            }
        }
    }
    
}

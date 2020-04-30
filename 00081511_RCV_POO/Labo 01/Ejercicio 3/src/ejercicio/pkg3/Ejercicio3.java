/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ejercicio.pkg3;

/**
 *
 * @author Pc-pc
 */
public class Ejercicio3 {

    /**
     * @param args the command line arguments
     */
    
    //Realiza una función recursiva que imprima la siguiente secuencia desde 1 hasta n:si n = 3, 1 2 3 2 1
    
    public static void fncSecuencia(int numero, int i){
        if (numero == 0);
        else if(numero == i ){
            System.out.println(numero);
            fncSecuencia( numero-1,  i-1);
        }else{
            System.out.println(i);
            fncSecuencia( numero,  i+1);
        }
    }
    public static void main(String[] args) {
        // TODO code application logic here
        fncSecuencia(5,  1);
    }
    
}

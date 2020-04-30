package com.RCV.c00081511;

import java.util.ArrayList;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        System.out.println("hola mundo");
        HerramientasMinecraft pico = new HerramientasMinecraft("Pico","Bronce", "Pico de Bronce"
                ,"100%","Herramienta usada para picar piedras");

        ArrayList<HerramientasMinecraft> listaHerramientas = new ArrayList<HerramientasMinecraft>();
        listaHerramientas.add(pico);
        int salir = 1;
        System.out.println("---SELECCIONE  UNA OPCION---");
        do {
            System.out.println(mainMenu());
            Scanner sc = new Scanner(System.in);
            salir = Integer.parseInt(sc.nextLine());
            switch (salir){
                case 1:
                    System.out.println(herramientasDispo());
                    Scanner sc2 = new Scanner(System.in);
                    System.out.println(agregarHerramiento(sc2.nextLine(), listaHerramientas));
                    break;
                case 2:
                    verHerramientas(listaHerramientas);
                    break;
                case 3:
                    System.out.println(herramientasTipo());
                    Scanner sc3 = new Scanner(System.in);
                    verHerramientasTipo(sc3.nextLine(),listaHerramientas);
                    break;
                case 4:
                    verEstados(listaHerramientas);
                    break;
                case 5:
                    vaciarTodo(listaHerramientas);
                    listaHerramientas.clear();
                    break;
                case 6:
                    salir = 0;
                    break;
                default:
                    System.out.println("opcion no encontrada");
                    break;
            }
        } while (salir != 0);
    }

    static String mainMenu(){
        return "1.Agregar herramienta a la lista \n 2.Consultar herramientas \n 3.Consultar herramientas de un tipo" +
                "\n 4.Ver estado de mis herramientas \n 5.Vaciar inventario \n 6.Salir";
    }

    static String herramientasDispo(){
        return "1.Agregar Pico \n 2.Agregar Espada \n 3.Agregar Pala" +
                "\n 4.Atras";
    }

    static String agregarHerramiento(String opcion, ArrayList lista){
        switch (opcion){
            case "1":
                lista.add(new HerramientasMinecraft("Pico","Bronce", "Pico de Bronce"
                        ,"100%","Herramienta usada para picar piedras")) ;
                return "---> Se ha agregado un Pico <---";

            case "2":
                lista.add(new HerramientasMinecraft("Espada","Bronce", "Espada de Bronce"
                        ,"100%","Herramienta para atacar")) ;
                return "---> Se ha agregado una Espada <---";

            case "3":
                lista.add(new HerramientasMinecraft("Pala","Bronce", "Pala de Bronce"
                        ,"100%","Herramienta usada para cavar")) ;
                return "---> Se ha agregado una Pala <---";
            case "4":
                return "---> Atras <---";
            default:
                return "---> Herramienta no encontrada <---";
        }
    }

    static void verHerramientas(ArrayList<HerramientasMinecraft> lista){
        int hasta = lista.size();
        for(int i = 0; i<hasta; i++){
            System.out.println("Usted tiene: " +lista.get(i).getTipo() + " Con estado: " + lista.get(i).getEstado());
        }
    }

    static String herramientasTipo(){
        return "1.Ver Picos \n 2.Ver Espadas \n 3.Ver Palas" +
                "\n 4.Atras";
    }

    static void tipoHerramientas(ArrayList<HerramientasMinecraft> lista, String tipo){
        int hasta = lista.size();
        for(int i = 0; i<hasta; i++){
            if(tipo.equals("1") && lista.get(i).getTipo().equals("Pico")){
                System.out.println("Usted tiene: " +lista.get(i).getTipo() + " Con estado: " + lista.get(i).getEstado());
            }
            else if(tipo.equals("2") && lista.get(i).getTipo().equals("Espada")){
                System.out.println("Usted tiene: " +lista.get(i).getTipo() + " Con estado: " + lista.get(i).getEstado());
            }
            else if(tipo.equals("3") && lista.get(i).getTipo().equals("Pala")){
                System.out.println("Usted tiene: " +lista.get(i).getTipo() + " Con estado: " + lista.get(i).getEstado());
            }
        }
    }

    static void verHerramientasTipo(String opcion, ArrayList lista){
        switch (opcion){
            case "1":
                tipoHerramientas(lista, "1");
                break;
            case "2":
                tipoHerramientas(lista, "2");
                break;
            case "3":
                tipoHerramientas(lista, "3");
                break;
            case "4":
                System.out.println("Atras");
                break;
            default:
                System.out.println("---> Herramienta no encontrada <---");
                break;
        }
    }

    static void verEstados(ArrayList<HerramientasMinecraft> lista){
        for (HerramientasMinecraft herr : lista) {
            System.out.println(herr.verEstado());
        }
    }

    static void vaciarTodo(ArrayList<HerramientasMinecraft> lista){
        for (HerramientasMinecraft herr : lista) {
            System.out.println(herr.tirarHerramienta());
        }
    }
}

package com.RCV.c00081511;

import java.util.ArrayList;

public class ParametroPago {
    private ArrayList<Moneda> modesDisponibles;
    private float valorP;
    private ArrayList<Float> montosDispo;

    public ParametroPago() {
        this.modesDisponibles = new ArrayList<Moneda>();
        this.montosDispo = new ArrayList<Float>();
        montosDispo.add((float)0.00);
        montosDispo.add((float)0.50);
        montosDispo.add((float)1.00);
        montosDispo.add((float)5.00);
    }

    public String mostrarDisponibilidad(){
        String info = "";
        for (int i = 0; i< modesDisponibles.size(); i++) {
            info = info.concat("\n"+ i +". "+ modesDisponibles.get(i).getTipo());
        }
        return info;
    }

    public String detalle(float num){
        String nota = "Ha estado activo por: " + num + " Segundos y \n";
        if(num <= 30){
            valorP = montosDispo.get(0);
            return nota +"Usted debe pagar $" + montosDispo.get(0) ;
        }
        if(num > 30 && num <= 60){
            valorP = montosDispo.get(1);
            return nota + "Usted debe pagar $" + montosDispo.get(1) ;
        }
        if(num > 60 && num <= 120){
            valorP = montosDispo.get(2);
            return nota + "Usted debe pagar $" + montosDispo.get(2) ;
        }else{
            valorP = montosDispo.get(3);
            return nota + "Usted debe pagar $" + montosDispo.get(3) ;
        }
    }

    public ArrayList<Moneda> getModesDisponibles() {
        return modesDisponibles;
    }

    public void setModesDisponibles(ArrayList<Moneda> modesDisponibles) {
        this.modesDisponibles = modesDisponibles;
    }

    public float getValorP() {
        return valorP;
    }

    public void setValorP(float valorP) {
        this.valorP = valorP;
    }

    public ArrayList<Float> getMontosDispo() {
        return montosDispo;
    }

    public void setMontosDispo(ArrayList<Float> montosDispo) {
        this.montosDispo = montosDispo;
    }
}

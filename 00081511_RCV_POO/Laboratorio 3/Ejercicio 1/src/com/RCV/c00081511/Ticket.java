package com.RCV.c00081511;

import java.util.Date;

public class Ticket {
    private String placa;
    private Date ingreso;
    private Date salida;
    private int estado;

    public Ticket(String placa) {
        this.placa = placa;
        this.ingreso = new Date();
        this.estado = 1;
    }



    public String getPlaca() {
        return placa;
    }

    public void setPlaca(String placa) {
        this.placa = placa;
    }

    public Date getIngreso() {
        return ingreso;
    }

    public void setIngreso(Date ingreso) {
        this.ingreso = ingreso;
    }

    public Date getSalida() {
        return salida;
    }

    public void setSalida(Date salida) {
        this.salida = salida;
    }

    public int getEstado() {
        return estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
    }
}

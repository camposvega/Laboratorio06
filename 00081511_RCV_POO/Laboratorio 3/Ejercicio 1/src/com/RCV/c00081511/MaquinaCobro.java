package com.RCV.c00081511;

import java.util.ArrayList;
import java.util.Date;

public class MaquinaCobro {
    private ArrayList<Ticket> lista;
    private ArrayList<Ticket> listaApoyo;
    private ParametroPago params;
    private float montoTotal;
    private float totalPagar;

    public MaquinaCobro(ArrayList<Ticket> lista) {
        this.lista = lista;
        this.listaApoyo = new ArrayList<Ticket>();
        this.montoTotal = 0;
        this.totalPagar = 0;
    }

    public MaquinaCobro() {
        //this.lista = lista;
        this.listaApoyo = new ArrayList<Ticket>();
        this.montoTotal = 0;
    }

    public String ticketAbiertos(){
        listaApoyo.clear();
        for (Ticket tkt: lista) {
            if(tkt.getEstado() == 1){
                listaApoyo.add(tkt);
            }
        }
        String info = "";
        for (int i = 0; i< listaApoyo.size(); i++) {
            info = info.concat("\n"+ i +". "+ listaApoyo.get(i).getPlaca());
        }
        return info;
    }

    public String totalPagar(Ticket tkt){
        tkt.setSalida(new Date());
        float segundos = - tkt.getIngreso().getTime() + tkt.getSalida().getTime();
        segundos = segundos/1000;
        System.out.println(segundos);
        return params.detalle(segundos);
    }

    public float calcularPago (int mon){
        System.out.println(totalPagar - params.getModesDisponibles().get(mon).getValor());
        return totalPagar - params.getModesDisponibles().get(mon).getValor();
    }

    public float getTotalPagar() {
        return totalPagar;
    }

    public void setTotalPagar(float totalPagar) {
        this.montoTotal = this.montoTotal + totalPagar;
        this.totalPagar = totalPagar;
    }

    public ParametroPago getParams() {
        return params;
    }

    public void setParams(ParametroPago params) {
        this.params = params;
    }

    public float getMontoTotal() {
        return montoTotal;
    }

    public void setMontoTotal(float montoTotal) {
        this.montoTotal = montoTotal;
    }

    public ArrayList<Ticket> getListaApoyo() {
        return listaApoyo;
    }

    public void setListaApoyo(ArrayList<Ticket> listaApoyo) {
        this.listaApoyo = listaApoyo;
    }

    public ArrayList<Ticket> getLista() {
        return lista;
    }

    public void setLista(ArrayList<Ticket> lista) {
        this.lista = lista;
    }
}

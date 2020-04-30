package com.RCV.c00081511;

import java.util.ArrayList;

public class MaquinaRegistro {
    private ArrayList<Ticket> listaTicket;
    private MaquinaCobro cobro;

    public MaquinaRegistro() {
        this.listaTicket = new ArrayList<Ticket>();
        this.cobro = new MaquinaCobro();
    }

    public String mainMenu(){
        return "1.Ingresar Automovíl \n 2. Salir del Parqueo \n 3.Consultar Ticket" +
                "\n 4.Monto Acumulado \n 5.salir";
    }

    public String infoTicket(String placa){
        Ticket tkt = listaTicket.get(Integer.parseInt(placa));
        String est = tkt.getEstado() == 1 ? "Abierto" : "Cerrado";
        return "Ticket: " + tkt.getPlaca() + "\n Con fecha entrada: "+ tkt.getIngreso().toString()
                + "\n Con estado: " + est;
    }

    public String getTickets(){
        String info = "";
        for (int i = 0; i< listaTicket.size(); i++) {
            info = info.concat("\n"+ i +". "+ listaTicket.get(i).getPlaca());
        }
        return info;
    }

    public ArrayList<Ticket> getListaTicket() {
        return listaTicket;
    }

    public void setListaTicket(ArrayList<Ticket> listaTicket) {
        this.listaTicket = listaTicket;
    }

    public MaquinaCobro getCobro() {
        return cobro;
    }

    public void setCobro(MaquinaCobro cobro) {
        this.cobro = cobro;
    }
}

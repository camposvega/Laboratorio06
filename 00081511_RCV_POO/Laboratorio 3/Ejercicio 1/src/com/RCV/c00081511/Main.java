package com.RCV.c00081511;

import javax.swing.*;

public class Main {

    public static void main(String[] args) {
	// write your code here
        MaquinaRegistro macRe = new MaquinaRegistro();
        ParametroPago parametroPago = new ParametroPago();
        parametroPago.getModesDisponibles().add(new Moneda((float) 0.05));
        parametroPago.getModesDisponibles().add(new Moneda((float) 0.10));
        parametroPago.getModesDisponibles().add(new Moneda((float) 0.25));
        parametroPago.getModesDisponibles().add(new Moneda((float) 1.00));
        macRe.getCobro().setParams(parametroPago);
        //JOptionPane.showInputDialog(null,macRe.mainMenu());

        String salir = "";
        do{
           salir =  JOptionPane.showInputDialog(null,macRe.mainMenu());

           switch (salir){
               case "1":
                   String placa = JOptionPane.showInputDialog(null,"Ingrese numer de placa.");
                   Ticket tkt = new Ticket(placa);
                   macRe.getListaTicket().add(tkt);
                   macRe.getCobro().setLista(macRe.getListaTicket());
                   break;
               case "2":
                   String op = JOptionPane.showInputDialog(null,
                           "Seleccione la placa a pagar \n" + macRe.getCobro().ticketAbiertos());
                   if(macRe.getCobro().getListaApoyo().isEmpty()) break;
                   Ticket tktPago = macRe.getCobro().getListaApoyo().get(Integer.parseInt(op));
                   JOptionPane.showMessageDialog(null,macRe.getCobro().totalPagar(tktPago));
                   if(macRe.getCobro().getParams().getValorP() > 0){
                       macRe.getCobro().setTotalPagar(macRe.getCobro().getParams().getValorP());
                       String numMoneda = JOptionPane.showInputDialog(null,
                               "Ingrese cantidad \n" + macRe.getCobro().getParams().mostrarDisponibilidad());
                       float estado = macRe.getCobro().calcularPago(Integer.parseInt(numMoneda));
                       if(estado > 0){
                           do{
                               numMoneda = JOptionPane.showInputDialog(null,
                                       "Ingrese cantidad \n" + macRe.getCobro().getParams().mostrarDisponibilidad());
                               estado = macRe.getCobro().calcularPago(Integer.parseInt(numMoneda));
                           }
                           while (estado > 0);
                       }
                       JOptionPane.showMessageDialog(null,"Retire: " + (-1*estado));
                       //System.out.println(macRe.getListaTicket().indexOf(macRe.getCobro().listaApoyo.get(Integer.parseInt(op))));
                       macRe.getListaTicket().get(macRe.getListaTicket().indexOf(macRe.getCobro().getListaApoyo().get(Integer.parseInt(op)))).setEstado(0);
                   }else {
                       macRe.getListaTicket().get(macRe.getListaTicket().indexOf(macRe.getCobro().getListaApoyo().get(Integer.parseInt(op)))).setEstado(0);
                   }
                   break;
               case "3":
                   String todas = JOptionPane.showInputDialog(null,macRe.getTickets());
                   JOptionPane.showInputDialog(null,macRe.infoTicket(todas));
                   break;
               case "4":
                   JOptionPane.showMessageDialog(null,"Acomulado: " + macRe.getCobro().getMontoTotal());
                   break;
           }
        }
        while (!salir.equals("5"));
    }

}

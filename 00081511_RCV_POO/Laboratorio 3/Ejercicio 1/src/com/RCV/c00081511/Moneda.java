package com.RCV.c00081511;

public class Moneda {
    private String tipo;
    private float valor;

    public Moneda(float valor) {
        this.tipo = "$" + valor;
        this.valor = valor;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public float getValor() {
        return valor;
    }

    public void setValor(float valor) {
        this.valor = valor;
    }
}

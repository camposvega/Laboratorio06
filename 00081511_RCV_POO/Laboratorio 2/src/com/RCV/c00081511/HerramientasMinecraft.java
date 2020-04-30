package com.RCV.c00081511;

public class HerramientasMinecraft {
    private String tipo;
    private String color;
    private String nombre;
    private String estado;
    private String descripcion;

    public HerramientasMinecraft(String tipo, String color, String nombre, String estado, String descripcion) {
        this.tipo = tipo;
        this.color = color;
        this.nombre = nombre;
        this.estado = estado;
        this.descripcion = descripcion;
    }

    public String verEstado(){
        return "El estado de la herramienta " + this.nombre +" es: " + this.estado ;
    }

    public String tirarHerramienta(){
        return "La herramienta de tipo: " + this.tipo + " y con nombre: "+ this.nombre + " ya no forma parte de su inventario.";
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getEstado() {
        return estado;
    }

    public void setEstado(String estado) {
        this.estado = estado;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }
}

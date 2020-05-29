/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package veterinariaprueba;

/**
 *
 * @author Bangho
 */
public class Cliente {
    
    int nro;
    String nombre;
    int antiguedad;
    Mascota[] mascotas;

    public Cliente(int nro, String nombre, int antiguedad, int cantMascota) {
        this.nro = nro;
        this.nombre = nombre;
        this.antiguedad = antiguedad;
        this.mascotas = new Mascota[cantMascota];
    }

    public int getNro() {
        return nro;
    }

    public void setNro(int nro) {
        this.nro = nro;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getAntiguedad() {
        return antiguedad;
    }

    public void setAntiguedad(int antiguedad) {
        this.antiguedad = antiguedad;
    }

    public Mascota[] getMascotas() {
        return mascotas;
    }

    public void setMascotas(Mascota[] mascotas) {
        this.mascotas = mascotas;
    }
    
    public void agregarMascota(Mascota p){
        
        for(int i=0;i<mascotas.length;i++){
            
            if(mascotas[i]==null){
                mascotas[i]=p;
                break;
            }
            
        }       
        
    }
    
    
    
}

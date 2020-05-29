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
public class Veterinaria {
    
    Cliente[] clientes;

    public Veterinaria(int cantidadClientes) {
        this.clientes = new Cliente[cantidadClientes];
    }

    public Cliente[] getClientes() {
        return clientes;
    }

    public void setClientes(Cliente[] clientes) {
        this.clientes = clientes;
    }
    
    public int cantidadClientes(){
        
        int cont=0;
        
        for (int i = 0; i < clientes.length; i++) {
            
            if(clientes[i]!=null){
                cont++;
            }
        }
        
        return cont;
    }
    
    public float promedioEdadMascotas(){
        
        float promedio=0;
        float suma=0;
        int cont=0;
        
        for (Cliente c : clientes) {
            if (c != null) {                
                cont=cont+c.getMascotas().length;
                
                Mascota[] m= c.getMascotas();
                
                for (Mascota i:m) {
                    if (i != null){
                    suma= suma+i.getEdad();
                    }
                }
                
            }
        }
        
        promedio=suma/cont;
        
        return promedio;
    }
    
    public int cantidadClientesMayor5(){
        
        int cont=0;
        
        for (int i = 0; i < clientes.length; i++) {
            
            if(clientes[i]!=null){
                
                if(clientes[i].getAntiguedad()>5){                    
                cont++;
                }
            }
        }
        
        return cont;
    }
    
    public void agregarCliente(Cliente p){
        
        for(int i=0;i<clientes.length;i++){
            
            if(clientes[i]==null){
                clientes[i]=p;
                break;
            }
            
        }       
        
    }
    
}

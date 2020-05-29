/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package veterinariaprueba;

import java.util.Scanner;

/**
 *
 * @author Bangho
 */
public class Principal {

    /**
     * @param args the command line arguments
     */
        public static void main(String[] args) {  
        Scanner entrada= new Scanner(System.in);
        Veterinaria veterinaria;
        int cantidadVeterinaria;
        
        
        //----Veterinaria
        
        System.out.println("Ingrese los Clientes que habra en la veterinaria\n");
        
        cantidadVeterinaria=entrada.nextInt();   
        veterinaria=new Veterinaria(cantidadVeterinaria);
        
        
        for(int i=0;i<cantidadVeterinaria;i++)
        {
          
        Cliente clientetemp;
            
        //----Clientes
        
        String nombre;
        int nro;
        int antiguedad; 
        int cantMascota;
        
        System.out.println("Ingrese datos de Cliente\n");
        
        System.out.println("Ingrese nombre=");
        nombre=entrada.nextLine();
        entrada.nextLine();
        
        System.out.println("Ingrese nro=\n");
        nro=entrada.nextInt();
        
        System.out.println("Ingrese antiguedad=\n");
        antiguedad=entrada.nextInt();
        
        System.out.println("Ingrese Cantidad de Mascotas=\n");
        cantMascota=entrada.nextInt();
              
        
        clientetemp= new Cliente(nro, nombre, antiguedad, cantMascota);
        
        for(int j=0;j<cantMascota;j++){
        
        //----Mascotas
        
        String nombreMascota;
        int edadMascota;
        
        System.out.println("Ingrese datos de Mascota "+j);
        
        System.out.println("Ingrese Nombre Mascota=");
        nombreMascota=entrada.nextLine();
        entrada.nextLine();
        
        System.out.println("Ingrese Edad Mascota=\n");
        edadMascota=entrada.nextInt();        
        
        
        Mascota p=new Mascota(nombreMascota,edadMascota);        
                        
        clientetemp.agregarMascota( p );     
        
        }     
        
        veterinaria.agregarCliente(clientetemp);
        
        }        
        
        System.out.println("La cantidad de clientes:"+veterinaria.cantidadClientes());
        
        System.out.println("Promedio edad mascotas:"+veterinaria.promedioEdadMascotas());
        
        System.out.println("La cantidad de clientes mayor a 5 años:"+veterinaria.cantidadClientesMayor5());
        
        
    }
    
}

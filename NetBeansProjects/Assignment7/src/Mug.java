
import java.util.Scanner;
import javafx.scene.paint.Color;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Shubham Hirpara
 *  I, Shubham Hirpara, student number 000770045, certify that all code submitted is my own work; that I have not copied it from any other source.  I also certify that I have not allowed my work to be copied by others.
 */
public class Mug extends TimsProduct{
    private Color color;
    private Mug(String Name,Color color, double cost, double price) {
        //calling super class constructor
        super(Name, cost, price);
        this.color = color;
    }
    public static Mug create(){
        //Validation 
        boolean flag = false;
        int choice = 0;
        while(!flag){
        System.out.println("Enter Mug color( 1=Blue, 2=Red )");
        Scanner sc = new Scanner(System.in);
        
        choice = sc.nextInt();
        if(choice == 1 || choice == 2){
            flag = true;
        }
        }
        switch( choice ){
            case 1:
                 return new Mug( "Mug" , Color.BLUE , 4.99 , 5.99);
                
            case 2:
                 return new Mug( "Mug" , Color.RED , 4.99 , 5.99);
            
                
        }
        //never run this return statement
     return null;
    }

    public Color getColor() {
        return color;
    }

    @Override
    public String toString() {
        //calling super class toString method.
        return super.toString() + "[ Color : " + color + " ]";
    }
    
    
}


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
public class Band extends TimsProduct{
    private Color color;
    private Band(String Name,Color color, double cost, double price) {
        super(Name, cost, price);
        this.color = color;
    }
    
    public static Band create(){
        //calling super class constructor
        boolean flag = false;
        int choice = 0;
        while(!flag){
        System.out.println("Enter Band color( 1=Black, 2=White )");
        Scanner sc = new Scanner(System.in);
        
        choice = sc.nextInt();
        if(choice == 1 || choice == 2){
            flag = true;
        }
        }
        switch( choice ){
            case 1:
                 return new Band( "Band" , Color.BLACK , 3.99 , 4.49);
                 
                
            case 2:
                 return new Band( "Band" , Color.WHITE , 4.99 , 5.99);
                
                
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

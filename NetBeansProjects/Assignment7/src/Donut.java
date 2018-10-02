
import java.util.Scanner;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author shubh
 */
public class Donut extends TimsProduct implements Consumable{
    private String description;
    private int calorieCount;

    private Donut(String Name, String description, double cost, double price, int calorieCount) {
        //calling super class constructor
        super(Name, cost, price);
        this.description = description;
        this.calorieCount = calorieCount;
    }
    public static Donut create(){
        boolean flag = false;
        int choice = 0;
        while(!flag){
        System.out.println("Enter Donut type( 1=cheese , 2=honey crunch )");
        Scanner sc = new Scanner(System.in);
        
        choice = sc.nextInt();
        if(choice == 1 || choice == 2){
            flag = true;
        }
        }
        switch( choice ){
            case 1:
                return new Donut( "Donut" , "cheese" , 1.50 , 1.99 , 300);
                
            case 2:
                return new Donut( "Donut" , "honey crunch" , 1.99 , 2.99 , 350);
                
                
        }
        //never run this return statement
    return null;
    }

    
    @Override
    public int getCalorieCount() {
        return calorieCount;
    }

    @Override
    public String getConsumptionMethod() {
        return "Eat";
    }
    @Override
    public String toString() {
        //calling super class toString method.
        return super.toString()+ "[ description : " + description + ", calorie : " + calorieCount + " ]";
    }
    
}

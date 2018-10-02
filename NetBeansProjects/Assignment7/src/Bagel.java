
import java.util.Scanner;

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
public class Bagel extends TimsProduct implements Consumable {

    private String description;
    private int calorieCount;

    //Making constructor private
    private Bagel(String Name, String description, double cost, double price, int calorieCount) {
        //calling super class constructor
        super(Name, cost, price);
        this.description = description;
        this.calorieCount = calorieCount;
    }

    public static Bagel create() {
        //Input validation-flag
        boolean flag = false;
        int choice = 0;
        while (!flag) {
            System.out.println("Enter Bagel type( 1=Everything , 2=jelepeno )");
            Scanner sc = new Scanner(System.in);

            choice = sc.nextInt();
            if (choice == 1 || choice == 2) {
                flag = true;
            }
        }
        switch (choice) {
            case 1:
                return new Bagel("Bagel", "Everything", 1.50, 1.99, 300);

            case 2:
                return new Bagel("Bagel", " jelepeno ", 1.99, 2.99, 350);

        }
        //never run this return statement
        return null;
    }

    //overrided Consumable interface methods
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
        return super.toString() + "[ description : " + description + ", calorie : " + calorieCount + " ]";
    }
}

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
public abstract class TimsProduct implements Commodity {

    //Declaring instance variables
    private String Name;
    private double cost;
    private double price;

    //constructor
    public TimsProduct(String Name, double cost, double price) {
        this.Name = Name;
        this.cost = cost;
        this.price = price;
    }

    

    public String getName() {
        return Name;
    }

    @Override
    public double getProductionCost() {
        return cost;
    }

    @Override
    public double getRetailPrice() {
        return price;
    }
    
    @Override
    public String toString() {
        return  "Name = " + Name + "      { "+ ", cost = " + cost + ", price=" + price + " }";
    }
}

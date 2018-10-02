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
public class TestClass {
    public static void main(String[] args) {
        //Calling TimOrder's create static method.
        TimsOrder to = TimsOrder.create();
        System.out.println(to);
        System.out.println("Total amount to be paid = " + to.getAmountDue());
        
    }
}

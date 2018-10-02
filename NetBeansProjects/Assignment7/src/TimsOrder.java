
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
public class TimsOrder {

    //initializing object of TimsProduct and TimsOrder as a static because to use in static method.
    private static TimsProduct[] tp;
    private static TimsOrder to;
    private int size;
    private String name;

    private TimsOrder(String name, int size) {
        this.name = name;
        this.size = size;

    }

    

    public static TimsOrder create() {
        System.out.println("Please enter name: ");
        Scanner sc = new Scanner(System.in);
        String name = sc.nextLine();
        System.out.println("Enter the number of item for your order ");
        int size = sc.nextInt();
        //Declaring TimsProducts objact
        tp = new TimsProduct[size];
        to = new TimsOrder(name, size);
        for (int i = 0; i < tp.length; i++) {
            boolean flag = false;
            int choice = 0;
            while (!flag) {
                System.out.println("Enter your choice of your item ( 1 = mug, 2=Donut, 3=Bagel, 4=Band )");
                choice = sc.nextInt();
                if (choice == 1 || choice == 2 || choice == 3 || choice == 4) {
                    flag = true;
                }
            }
            switch (choice) {
                case 1:
                    tp[i] = Mug.create();
                    break;
                case 2:
                    tp[i] = Donut.create();
                    break;
                case 3:
                    tp[i] = Bagel.create();
                    break;
                case 4:
                    tp[i] = Band.create();
                    break;

            }

        }

        return to;

    }

    public double getAmountDue() {

        double totalAmount = 0;
        for (int i = 0; i < tp.length; i++) {
            totalAmount = totalAmount + tp[i].getRetailPrice();
        }
        return totalAmount;
    }
    @Override
    public String toString() {
        String finalOutput = "Summary of Order \n ---------------- \n Order for: "+ name + "\n";
        String TimsProducts = "";
        for (int i = 0; i < tp.length; i++) {
            //calling all array members of toString method.
            TimsProducts = TimsProducts + tp[i] + "\n";
        }
        finalOutput = finalOutput + TimsProducts;
        return finalOutput;
    }
}

/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : carpet fitter calculator
 * 
 * ############################# */

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_21_11_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            const double TRAVEL_COST = 0.45;//per km
            const double FITTING_COST = 3.25;//per square meter
            int number_of_fittings = 0;//the total costs of all fittings is divided by this to obtain average
            double total_costs = 0;//all costs together
            double average_costs = 0;//the average - all the costs added together divided by the amount of fittings
            Console.WriteLine("The Carpet Fitting Calculator");
            Console.WriteLine("=================================");
            Console.Write("Enter a 0 to end or a 1 to input carpet fitting details >> ");
            //prompts user to enter a number, 1 to begin the calculor and 0 to end it.
            //other values will read "invalid input! Try again >> "
            int start_calculator = int.Parse(Console.ReadLine());
            while (start_calculator != 0)
                //this condition inside the while loop allows for 0 to become the sentinel value,
                //so that of it is entered the loop will be broken and display total and average costs at the end of the programme
            {
                if (start_calculator == 1)
                    //this if statement decides whether or not the input will allow the calculator to begin. It has to be 1 in this case.
                    //any other inputs will not allow the calculator to work
                {
                    Console.Write("Enter a distance (km) >> ");
                    double distance = double.Parse(Console.ReadLine());//works out the distance to travel
                    Console.Write("Enter a carpet size (sqr m) >> ");
                    double carpet_size = double.Parse(Console.ReadLine());//works out the size of the carpet
                    double cost_of_fitting = ((TRAVEL_COST * distance) + (carpet_size * FITTING_COST));//works out the initital charge for the customer
                    //next there are if statements that apply discounts based on the cost of the carpet fitting. 
                    //the higher the cost the higher the discount
                    if (cost_of_fitting > 500)
                    {
                        cost_of_fitting = cost_of_fitting - (cost_of_fitting * 0.15);
                    }
                    else if ((cost_of_fitting < 500) && (cost_of_fitting > 250))
                    {
                        cost_of_fitting = cost_of_fitting - (cost_of_fitting * 0.10);

                    }
                    else//this statement is left empty as there is no discount applied to costs below 250
                    {

                    }
                    Console.WriteLine("Cost of fitting:\t{0:c}", cost_of_fitting);//this displays the final total
                    number_of_fittings = number_of_fittings + 1;
                    total_costs = total_costs + cost_of_fitting;//adds the last cost of fitting to all the other costs of fitting
                    average_costs = total_costs / number_of_fittings;//calculates the average cost of all fittings
                    Console.WriteLine();
                    Console.Write("Enter a 0 or a 1 to input another carpet fitting details >> ");
                    //asks the user if they would like to use the calculator again to calculate more costs
                    start_calculator = int.Parse(Console.ReadLine());
                    //assigns a new value to start calculator and brings it to the beginning of the loop to decide whether or not it meets the condition
                }

                else
                {
                    Console.Write("invalid input! Try again >> ");//this is displayed when an input other than 1 or 0 is entered
                    start_calculator = int.Parse(Console.ReadLine());
                    //reassigns a new value to start calculator and brings it to the beginning of the loop 
                    //again and if it meets the conditions,
                    //the calculator will send, or start, or "invalid input! Try again >> " will be displayed
                }
            }
            Console.WriteLine("Total costs:\t{0:c}", total_costs);//displays all the costs charged during the use of the programme 
            Console.WriteLine("Average costs:\t{0:c}", average_costs);//displays the average of all the costs charged during the use of the programme


        }
    }
}

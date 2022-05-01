namespace TVLABEXTRA
{
    public class Television
    {
        private static int count;
        private string MANUFACTURER;
        private int SCREEN_SIZE;
        private bool isAvailable;
        public double price;
        private int numPayments;

        public Television(string MANUFACTURER, int SCREEN_SIZE) // This constructor assigns a TV a specific MAnufacturer and size, otherwise it assumes its price is 500, only one payment needed, and that it is already availible
        {
            this.MANUFACTURER = MANUFACTURER;
            this.SCREEN_SIZE = SCREEN_SIZE;
            isAvailable =true;
            price = 500.00;
            numPayments = 1;

        }
        public  void SetPrice(double temp) // sets the variable in question to a temporary variable of the same type
        {
            price = temp;
        }

        public double GetPrice() // Returns the variable to the program
        {
            return price;
        }

        public void SetNumPayments(int temp) // sets the variable in question to a temporary variable of the same type
        {
            numPayments = temp;
        }
        public  int GetNumPayments() // Returns the variable to the program
        {
            return numPayments;
        }
       
        public  string GetManufacturer() // Returns the variable to the program
        {
            return MANUFACTURER;
        }

        public  int GetScreenSize() // Returns the variable to the program
        {
            return SCREEN_SIZE;
        }

        public string ToString() //Checking if the TV is availible, and states aspects of a TV related to a purchase, informs user if TV is not availible
        {
            if (isAvailable == true)
            {
                return "A " + SCREEN_SIZE + " inch " + MANUFACTURER + "is available for purchase for $" + price;
            }
            else
            {
                return "You bought a " + SCREEN_SIZE + " inch " + MANUFACTURER + "TV. You'll pay $" + GetPricePerPayment()+" "+ numPayments + "time(s).";
            }
        }

        public void BuyTV () // Once a tv is bought, it's availibility has changed 
        {
            isAvailable = false;
            

        }

        public void ReturnTV() // Once a tv is returned, it's now availible once again
        {
            isAvailable = true;
           
        }

        public void  IncreasePrice() // Increases the price of a tv by $100
        {
            price += 100.00;
            
        }

        public void DecreasePrice() //Decreases the price of a tv by $100
        {
            price -= 100.00;
            
        }

        public double GetPricePerPayment() // Calculates a payment plan for the user based on the price of the tv and the desired amount of pmts, returns value to the program
        {
            
            return price / numPayments;
        }



    }



}
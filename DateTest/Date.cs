namespace DateTest
{

    public class Date
    {
        int month{get; set;}
        int day{get; set;}
        int year{get; set;}

        public Date(int month, int day, int year){
            this.month = month;
            this.day = day;
            this.year = year;
        }

        public void DisplayDate(){
            System.Console.WriteLine($"{month}/{day}/{year}");
        }
    }
}
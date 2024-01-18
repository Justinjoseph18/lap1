using System;
class Customer{
    public string name;
    public int salary;
    public int transaction;
    public static void eligibleOrNot(int salaryy,int transactionn){
        if(salaryy>=10000 && transactionn>50000)
        {
            Console.WriteLine("eligible for loan");
        }
        else{
            Console.WriteLine("not eligible for loan");
        }
    }
}
class Program{
    static void Main(string[] args){
        Customer lcustomer=new Customer();
        lcustomer.name="justin";
        lcustomer.salary=9000;
        lcustomer.transaction=65000;
    Customer.eligibleOrNot(lcustomer.salary,lcustomer.transaction);
    }
}
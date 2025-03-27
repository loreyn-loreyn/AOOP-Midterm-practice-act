using System;

class Account{
    
    private int accountNumber;
    private string accountHolder;
    private float balance;
    
    public Account(){
        this.accountNumber = 0;
        this.accountHolder ="";
        this.balance = 0;
    }
    
    public Account(int accountNumber, string accountHolder, float balance){
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }
    
    public void Deposit(){
        Console.Write("\nEnter Account Number: ");
        accountNumber = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter Account Holder's Name: ");
        accountHolder = Console.ReadLine();
        
        Console.Write("Enter the amount you want to Deposit: ");
        float deposit = Convert.ToSingle(Console.ReadLine());
        
        balance += deposit;
    }
    
    public void Withdraw(){
        Console.Write("\nEnter the amount you want to Withdraw: ");
        float withdraw = Convert.ToSingle(Console.ReadLine());
        
        balance -= withdraw;
    }
    
    public void DisplayBalance(){
        Console.Write($"\nYour current balance is: {balance}");
    }

}

class BankAccount{
        
    public static void Main(){
        
        Account acc = new Account();
        
        char choice = 'y';
        
        do{
            Console.Write("\n1. Deposit\n2. Withdraw Cash\n3. Display Balance\n\n");
            Console.Write("Enter the action you want to make: ");
            int act = Convert.ToInt32(Console.ReadLine());
            
            switch(act){
                case 1: 
                    acc.Deposit();
                    break;
                case 2:
                    acc.Withdraw();
                    break;
                case 3:
                    acc.DisplayBalance();
                    break;
                default:
                    Console.Write("Number of choice not included in the list. Do you want to try again? y/n: ");
                    choice = Convert.ToChar(Console.ReadLine());
                    break;
            }
            
            Console.Write("\n\nEnter 'y' if you want to do another transaction otherwise enter press any other keys: ");
            choice = Convert.ToChar(Console.ReadLine());
            
        }
        while(choice == 'y' || choice == 'Y');
    }
    
}
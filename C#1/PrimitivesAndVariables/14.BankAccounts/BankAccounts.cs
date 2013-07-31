using System;
using System.Data;

class BankAccount
{
    static void Main()
    {
        Console.WriteLine("Personal Information:");
        string firstName, middleName, lastName, bankName, bic, moneyBalance, IBAN, creditcard1, creditcard2, creditcard3;
        firstName = "Ivan";
        middleName = "Ivanov";
        lastName = "Ivanov";
        moneyBalance = "XXX BGN";
        bankName = "UBB";
        IBAN = "BGXX XXXX XXXX XXXX XXXX XX";
        bic = "BG UBB XX";
        creditcard1 = "XXXXXXXXXXXXXXXXXXX";
        creditcard2 = "XXXXXXXXXXXXXXXXXXX";
        creditcard3 = "XXXXXXXXXXXXXXXXXXX";
        Console.WriteLine("First name: {0}\nMiddle name: {1}\nLast name: {2}\nYour balance: {3}\nYour bank: {4}\nIBAN: {5}\nBIC: {6}\nCredit card 1: {7}\nCredit card 2: {8}\nCredit card 3: {9}", firstName, middleName, lastName, moneyBalance, bankName, IBAN, bic, creditcard1, creditcard2, creditcard3);
    }
}
Imports System.Console

Module Program
    Sub Main(args As String())
        Dim Type As String 
        Dim Input As Double 
        Dim Output As Single 
        Dim ConversionRate As Single 
        WriteLine("What is the currency conversion rate? (the amount of pound sterling in one dollar)")
        ConversionRate = ReadLine()
        WriteLine("Welcome to the currency converter! If you would like to convert £ to $, enter '$'.")
        WriteLine("If you want to convert $ to £, enter '£'")
        Type = ReadLine()
        If Type = "£" Then
            WriteLine("How many US Dollars? $")
            Input = ReadLine()
            Output = Input * ConversionRate
            
            
            ElseIf Type = "$" Then
                WriteLine("How many Pounds Sterling? £")
                Input = ReadLine()
                Output = Input / ConversionRate
               
                
                Else 
                    WriteLine("You have not entered a correct mode!")
        End If
        
        WriteLine("Currency converted! Answer is " & Output & " .")
        
    End Sub
End Module

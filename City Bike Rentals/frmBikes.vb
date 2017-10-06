' Program:    City Bike Rentals
' Author:     Tu Tong
' Date:       October 6, 2017
' Purpose:    This application calculate and displays
'             the total cost of renting multiple bikes
'             for a 24-hour period.

' Turn off strict type checking
Option Strict Off

Public Class frmBikes

    ' Cost per bike rental - a class variable 
    ' that used In multiple procedures
    Const _cdecPricePerBike As Decimal = 9.95

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' This event handler is executed when the user taps or clicks the
        ' Calculate button. It calculates and displays the cost 
        ' of the bikes rented (number of bikes times the cost per bike).

        ' Declare and initialize the variables
        Dim strNumberOfBikes As String
        Dim intNumberOfBikes As Integer
        Dim decTotalCost As Decimal

        ' Placing the number of bikes rented in a variable
        ' and convert the value to an integer
        strNumberOfBikes = txtNumnerOfBikes.Text
        intNumberOfBikes = Convert.ToInt32(strNumberOfBikes)

        ' Calculating the total cost of bikes rented
        decTotalCost = intNumberOfBikes * _cdecPricePerBike

        ' Convert the decimal total cost of bikes rented
        ' to a string currency value and place it in 
        ' the text property of the Total Cost label
        lblTotalCost.Text = decTotalCost.ToString("C")

    End Sub

End Class

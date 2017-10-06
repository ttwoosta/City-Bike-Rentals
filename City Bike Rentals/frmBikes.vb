' Program:    City Bike Rentals
' Author:     Tu Tong
' Date:       October 6, 2017
' Purpose:    This application calculate and displays
'             the total cost of renting multiple bikes
'             for a 24-hour period.

' Turn on strict type checking,
' to prevent automatic conversion of values
Option Strict On

Public Class frmBikes

    ' Cost per bike rental - a class variable 
    ' that used In multiple procedures
    Const _cdecPricePerBike As Decimal = 9.95D

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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user taps or clicks
        ' the Clear button. It clears the number of bikes text box
        ' and Text property of the Total Cost label.
        ' Then, it sets the focus on the Number of Bikes TextBox object.

        txtNumnerOfBikes.Clear()
        lblTotalCost.Text = ""
        txtNumnerOfBikes.Focus()

    End Sub

    Private Sub frmBikes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded.
        ' It displays the cost heading, clears the Text property
        ' of the Total Cost label, and set the focus on 
        ' the Number of Bikes TextBox object

        lblCostHeading.Text = _cdecPricePerBike.ToString("C") & " per Bike for 24 Hours"
        lblTotalCost.Text = ""
        txtNumnerOfBikes.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the window and terminate the application

        Close()

    End Sub

End Class

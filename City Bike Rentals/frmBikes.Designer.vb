<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBikes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picBikes = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblCostHeading = New System.Windows.Forms.Label()
        Me.lblNumberOfBikes = New System.Windows.Forms.Label()
        Me.txtNumnerOfBikes = New System.Windows.Forms.TextBox()
        Me.lblTotalCostLabel = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picBikes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBikes
        '
        Me.picBikes.Location = New System.Drawing.Point(0, 278)
        Me.picBikes.Name = "picBikes"
        Me.picBikes.Size = New System.Drawing.Size(407, 175)
        Me.picBikes.TabIndex = 0
        Me.picBikes.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(62, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(283, 35)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "City Bike Rentals"
        '
        'lblCostHeading
        '
        Me.lblCostHeading.AutoSize = True
        Me.lblCostHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostHeading.Location = New System.Drawing.Point(75, 44)
        Me.lblCostHeading.Name = "lblCostHeading"
        Me.lblCostHeading.Size = New System.Drawing.Size(257, 25)
        Me.lblCostHeading.TabIndex = 2
        Me.lblCostHeading.Text = "$X.XX per Bike for 24 Hours"
        '
        'lblNumberOfBikes
        '
        Me.lblNumberOfBikes.AutoSize = True
        Me.lblNumberOfBikes.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfBikes.Location = New System.Drawing.Point(25, 89)
        Me.lblNumberOfBikes.Name = "lblNumberOfBikes"
        Me.lblNumberOfBikes.Size = New System.Drawing.Size(224, 22)
        Me.lblNumberOfBikes.TabIndex = 3
        Me.lblNumberOfBikes.Text = "Number of Bike Rentals:"
        '
        'txtNumnerOfBikes
        '
        Me.txtNumnerOfBikes.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumnerOfBikes.Location = New System.Drawing.Point(305, 86)
        Me.txtNumnerOfBikes.Name = "txtNumnerOfBikes"
        Me.txtNumnerOfBikes.Size = New System.Drawing.Size(39, 30)
        Me.txtNumnerOfBikes.TabIndex = 4
        Me.txtNumnerOfBikes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalCostLabel
        '
        Me.lblTotalCostLabel.AutoSize = True
        Me.lblTotalCostLabel.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostLabel.Location = New System.Drawing.Point(25, 134)
        Me.lblTotalCostLabel.Name = "lblTotalCostLabel"
        Me.lblTotalCostLabel.Size = New System.Drawing.Size(248, 22)
        Me.lblTotalCostLabel.TabIndex = 5
        Me.lblTotalCostLabel.Text = "Total Cost of Bikes Rented:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(301, 134)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(81, 22)
        Me.lblTotalCost.TabIndex = 6
        Me.lblTotalCost.Text = "$888.88"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(5, 215)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(125, 27)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(136, 215)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(130, 27)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(272, 215)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(130, 27)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmBikes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 453)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotalCostLabel)
        Me.Controls.Add(Me.txtNumnerOfBikes)
        Me.Controls.Add(Me.lblNumberOfBikes)
        Me.Controls.Add(Me.lblCostHeading)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picBikes)
        Me.Name = "frmBikes"
        Me.Text = "City Bike Rentals"
        CType(Me.picBikes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBikes As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblCostHeading As Label
    Friend WithEvents lblNumberOfBikes As Label
    Friend WithEvents txtNumnerOfBikes As TextBox
    Friend WithEvents lblTotalCostLabel As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.gbSize = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbLarge = New System.Windows.Forms.RadioButton()
        Me.rbMedium = New System.Windows.Forms.RadioButton()
        Me.rbSmall = New System.Windows.Forms.RadioButton()
        Me.gbCrust = New System.Windows.Forms.GroupBox()
        Me.rbThick = New System.Windows.Forms.RadioButton()
        Me.rbThin = New System.Windows.Forms.RadioButton()
        Me.gbOrderType = New System.Windows.Forms.GroupBox()
        Me.rbTakeOut = New System.Windows.Forms.RadioButton()
        Me.rbDineIn = New System.Windows.Forms.RadioButton()
        Me.gbToppings = New System.Windows.Forms.GroupBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.clearToppingsBtn = New System.Windows.Forms.Button()
        Me.computeBtn = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.totalTbox = New System.Windows.Forms.TextBox()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.clearAllBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.receiptBox = New System.Windows.Forms.RichTextBox()
        Me.gbSize.SuspendLayout()
        Me.gbCrust.SuspendLayout()
        Me.gbOrderType.SuspendLayout()
        Me.gbToppings.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSize
        '
        Me.gbSize.Controls.Add(Me.Label3)
        Me.gbSize.Controls.Add(Me.Label2)
        Me.gbSize.Controls.Add(Me.Label1)
        Me.gbSize.Controls.Add(Me.rbLarge)
        Me.gbSize.Controls.Add(Me.rbMedium)
        Me.gbSize.Controls.Add(Me.rbSmall)
        Me.gbSize.Location = New System.Drawing.Point(69, 87)
        Me.gbSize.Name = "gbSize"
        Me.gbSize.Size = New System.Drawing.Size(136, 126)
        Me.gbSize.TabIndex = 0
        Me.gbSize.TabStop = False
        Me.gbSize.Text = "Size"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "120₱"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "100₱"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "80₱"
        '
        'rbLarge
        '
        Me.rbLarge.AutoSize = True
        Me.rbLarge.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLarge.Location = New System.Drawing.Point(6, 95)
        Me.rbLarge.Name = "rbLarge"
        Me.rbLarge.Size = New System.Drawing.Size(55, 18)
        Me.rbLarge.TabIndex = 2
        Me.rbLarge.TabStop = True
        Me.rbLarge.Text = "Large"
        Me.rbLarge.UseVisualStyleBackColor = True
        '
        'rbMedium
        '
        Me.rbMedium.AutoSize = True
        Me.rbMedium.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMedium.Location = New System.Drawing.Point(6, 66)
        Me.rbMedium.Name = "rbMedium"
        Me.rbMedium.Size = New System.Drawing.Size(67, 18)
        Me.rbMedium.TabIndex = 1
        Me.rbMedium.TabStop = True
        Me.rbMedium.Text = "Medium"
        Me.rbMedium.UseVisualStyleBackColor = True
        '
        'rbSmall
        '
        Me.rbSmall.AutoSize = True
        Me.rbSmall.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSmall.Location = New System.Drawing.Point(6, 37)
        Me.rbSmall.Name = "rbSmall"
        Me.rbSmall.Size = New System.Drawing.Size(52, 18)
        Me.rbSmall.TabIndex = 0
        Me.rbSmall.TabStop = True
        Me.rbSmall.Text = "Small"
        Me.rbSmall.UseVisualStyleBackColor = True
        '
        'gbCrust
        '
        Me.gbCrust.Controls.Add(Me.rbThick)
        Me.gbCrust.Controls.Add(Me.rbThin)
        Me.gbCrust.Location = New System.Drawing.Point(69, 224)
        Me.gbCrust.Name = "gbCrust"
        Me.gbCrust.Size = New System.Drawing.Size(136, 98)
        Me.gbCrust.TabIndex = 6
        Me.gbCrust.TabStop = False
        Me.gbCrust.Text = "Crust Type"
        '
        'rbThick
        '
        Me.rbThick.AutoSize = True
        Me.rbThick.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbThick.Location = New System.Drawing.Point(6, 66)
        Me.rbThick.Name = "rbThick"
        Me.rbThick.Size = New System.Drawing.Size(86, 18)
        Me.rbThick.TabIndex = 1
        Me.rbThick.TabStop = True
        Me.rbThick.Text = "Thick Crust"
        Me.rbThick.UseVisualStyleBackColor = True
        '
        'rbThin
        '
        Me.rbThin.AutoSize = True
        Me.rbThin.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbThin.Location = New System.Drawing.Point(6, 37)
        Me.rbThin.Name = "rbThin"
        Me.rbThin.Size = New System.Drawing.Size(81, 18)
        Me.rbThin.TabIndex = 0
        Me.rbThin.TabStop = True
        Me.rbThin.Text = "Thin Crust"
        Me.rbThin.UseVisualStyleBackColor = True
        '
        'gbOrderType
        '
        Me.gbOrderType.Controls.Add(Me.rbTakeOut)
        Me.gbOrderType.Controls.Add(Me.rbDineIn)
        Me.gbOrderType.Location = New System.Drawing.Point(69, 335)
        Me.gbOrderType.Name = "gbOrderType"
        Me.gbOrderType.Size = New System.Drawing.Size(136, 98)
        Me.gbOrderType.TabIndex = 7
        Me.gbOrderType.TabStop = False
        Me.gbOrderType.Text = "Order Type"
        '
        'rbTakeOut
        '
        Me.rbTakeOut.AutoSize = True
        Me.rbTakeOut.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTakeOut.Location = New System.Drawing.Point(6, 66)
        Me.rbTakeOut.Name = "rbTakeOut"
        Me.rbTakeOut.Size = New System.Drawing.Size(77, 18)
        Me.rbTakeOut.TabIndex = 1
        Me.rbTakeOut.TabStop = True
        Me.rbTakeOut.Text = "Take Out"
        Me.rbTakeOut.UseVisualStyleBackColor = True
        '
        'rbDineIn
        '
        Me.rbDineIn.AutoSize = True
        Me.rbDineIn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDineIn.Location = New System.Drawing.Point(6, 37)
        Me.rbDineIn.Name = "rbDineIn"
        Me.rbDineIn.Size = New System.Drawing.Size(64, 18)
        Me.rbDineIn.TabIndex = 0
        Me.rbDineIn.TabStop = True
        Me.rbDineIn.Text = "Dine In"
        Me.rbDineIn.UseVisualStyleBackColor = True
        '
        'gbToppings
        '
        Me.gbToppings.Controls.Add(Me.CheckBox6)
        Me.gbToppings.Controls.Add(Me.CheckBox5)
        Me.gbToppings.Controls.Add(Me.CheckBox4)
        Me.gbToppings.Controls.Add(Me.CheckBox3)
        Me.gbToppings.Controls.Add(Me.CheckBox2)
        Me.gbToppings.Controls.Add(Me.CheckBox1)
        Me.gbToppings.Location = New System.Drawing.Point(225, 87)
        Me.gbToppings.Name = "gbToppings"
        Me.gbToppings.Size = New System.Drawing.Size(277, 126)
        Me.gbToppings.TabIndex = 8
        Me.gbToppings.TabStop = False
        Me.gbToppings.Text = "Extra Toppings (15₱ Each)"
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(159, 95)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(73, 17)
        Me.CheckBox6.TabIndex = 20
        Me.CheckBox6.Text = "Tomatoes"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(159, 65)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(97, 17)
        Me.CheckBox5.TabIndex = 19
        Me.CheckBox5.Text = "Green Peppers"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(159, 34)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox4.TabIndex = 18
        Me.CheckBox4.Text = "Onions"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(32, 94)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(85, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "Black Olives"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(32, 65)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(80, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Mushrooms"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(32, 34)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(89, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Extra Cheese"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'clearToppingsBtn
        '
        Me.clearToppingsBtn.Location = New System.Drawing.Point(372, 229)
        Me.clearToppingsBtn.Name = "clearToppingsBtn"
        Me.clearToppingsBtn.Size = New System.Drawing.Size(130, 40)
        Me.clearToppingsBtn.TabIndex = 10
        Me.clearToppingsBtn.Text = "Clear Toppings"
        Me.clearToppingsBtn.UseVisualStyleBackColor = True
        '
        'computeBtn
        '
        Me.computeBtn.Location = New System.Drawing.Point(225, 229)
        Me.computeBtn.Name = "computeBtn"
        Me.computeBtn.Size = New System.Drawing.Size(130, 40)
        Me.computeBtn.TabIndex = 11
        Me.computeBtn.Text = "Build Pizza"
        Me.computeBtn.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.totalTbox)
        Me.GroupBox5.Location = New System.Drawing.Point(225, 285)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(277, 73)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Total"
        '
        'totalTbox
        '
        Me.totalTbox.Location = New System.Drawing.Point(20, 31)
        Me.totalTbox.Name = "totalTbox"
        Me.totalTbox.Size = New System.Drawing.Size(241, 20)
        Me.totalTbox.TabIndex = 0
        Me.totalTbox.Text = "0"
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(225, 372)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(130, 61)
        Me.saveBtn.TabIndex = 13
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'clearAllBtn
        '
        Me.clearAllBtn.Location = New System.Drawing.Point(372, 372)
        Me.clearAllBtn.Name = "clearAllBtn"
        Me.clearAllBtn.Size = New System.Drawing.Size(130, 61)
        Me.clearAllBtn.TabIndex = 14
        Me.clearAllBtn.Text = "Clear All"
        Me.clearAllBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(741, 70)
        Me.Panel1.TabIndex = 15
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.logo
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(670, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 67)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 67)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(65, 443)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(96, 18)
        Me.lblDate.TabIndex = 16
        Me.lblDate.Text = "Date Today: "
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(579, 444)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(98, 18)
        Me.lblTime.TabIndex = 17
        Me.lblTime.Text = "Time Today: "
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.receiptBox)
        Me.GroupBox1.Location = New System.Drawing.Point(518, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 346)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Receipt"
        '
        'receiptBox
        '
        Me.receiptBox.Location = New System.Drawing.Point(9, 20)
        Me.receiptBox.Name = "receiptBox"
        Me.receiptBox.Size = New System.Drawing.Size(143, 316)
        Me.receiptBox.TabIndex = 0
        Me.receiptBox.Text = "            Order Receipt:" & Global.Microsoft.VisualBasic.ChrW(10) & "---------------------------------------------" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Size:" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) &
    "Crust Type:" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Order Type:" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Extra Toppings: " & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Total:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(741, 468)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.clearAllBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.computeBtn)
        Me.Controls.Add(Me.clearToppingsBtn)
        Me.Controls.Add(Me.gbToppings)
        Me.Controls.Add(Me.gbOrderType)
        Me.Controls.Add(Me.gbCrust)
        Me.Controls.Add(Me.gbSize)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pizza Max"
        Me.gbSize.ResumeLayout(False)
        Me.gbSize.PerformLayout()
        Me.gbCrust.ResumeLayout(False)
        Me.gbCrust.PerformLayout()
        Me.gbOrderType.ResumeLayout(False)
        Me.gbOrderType.PerformLayout()
        Me.gbToppings.ResumeLayout(False)
        Me.gbToppings.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbSize As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rbLarge As RadioButton
    Friend WithEvents rbMedium As RadioButton
    Friend WithEvents rbSmall As RadioButton
    Friend WithEvents gbCrust As GroupBox
    Friend WithEvents rbThick As RadioButton
    Friend WithEvents rbThin As RadioButton
    Friend WithEvents gbOrderType As GroupBox
    Friend WithEvents rbTakeOut As RadioButton
    Friend WithEvents rbDineIn As RadioButton
    Friend WithEvents gbToppings As GroupBox
    Friend WithEvents clearToppingsBtn As Button
    Friend WithEvents computeBtn As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents totalTbox As TextBox
    Friend WithEvents saveBtn As Button
    Friend WithEvents clearAllBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents receiptBox As RichTextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class

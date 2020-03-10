;#DropDB Income_ExpenseEasyTest

#Application Income_ExpenseWin
#Application Income_ExpenseWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef Income_ExpenseWin

*Action About...
 
*Action OK

#EndIf

#IfDef Income_ExpenseWeb
*Action Navigation(My Details)
#EndIf

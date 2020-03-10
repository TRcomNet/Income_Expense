using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace Income_Expense.Module.BusinessObjects
{
  [DefaultClassOptions]
 
  public class Expenses : XPObject
  { 
    public Expenses(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      
    }


    Currencies _currencies;
    decimal _amount;
    string _expenseName;

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string ExpenseName
    {
      get => _expenseName;
      set => SetPropertyValue(nameof(ExpenseName), ref _expenseName, value);
    }


    public decimal Amount
    {
      get => _amount;
      set => SetPropertyValue(nameof(Amount), ref _amount, value);
    }

    
    public Currencies Currencies
    {
      get => _currencies;
      set => SetPropertyValue(nameof(Currencies), ref _currencies, value);
    }

    [Association]
    //[DataSourceCriteria("[CategoryTypeName] = Expense")]
    public XPCollection<Categories> ExpenseCategories
    {
      get
      {
        return GetCollection<Categories>(nameof(ExpenseCategories));
      }
    }

  }
}
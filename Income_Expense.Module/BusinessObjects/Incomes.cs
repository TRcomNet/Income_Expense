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
  
  public class Incomes : XPObject
  { 
    public Incomes(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      
    }

    Currencies _currencies;
    decimal _amount;
    string _ıncomeName;

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string IncomeName
    {
      get => _ıncomeName;
      set => SetPropertyValue(nameof(IncomeName), ref _ıncomeName, value);
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
    //[DataSourceCriteriaProperty("CategoryTypeName = Income")]
    public XPCollection<Categories> IncomeCategories
    {
      get
      {
        return GetCollection<Categories>(nameof(IncomeCategories));
      }
    }

  }
}
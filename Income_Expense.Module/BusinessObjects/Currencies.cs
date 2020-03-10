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
  
  public class Currencies : XPObject
  { 
    public Currencies(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      
    }


    string _currenciesName;

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string CurrenciesName
    {
      get => _currenciesName;
      set => SetPropertyValue(nameof(CurrenciesName), ref _currenciesName, value);
    }


  }
}
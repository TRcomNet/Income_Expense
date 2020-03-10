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
  
  public class CategoryTypes : XPObject
  { 
    public CategoryTypes(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
      
    }


    string _categoryTypeName;

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string CategoryTypeName
    {
      get => _categoryTypeName;
      set => SetPropertyValue(nameof(CategoryTypeName), ref _categoryTypeName, value);
    }
  }
}
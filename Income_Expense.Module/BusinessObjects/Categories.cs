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
  
  public class Categories : XPObject
  { 
    public Categories(Session session)
        : base(session)
    {
    }
    public override void AfterConstruction()
    {
      base.AfterConstruction();
    }


    CategoryTypes _categoryTypeName;
    Expenses _expenses;
    Incomes _ıncomes;
    string _categoryIcon;
    string _categoryColor;
    string _categoryName;

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string CategoryName
    {
      get => _categoryName;
      set => SetPropertyValue(nameof(CategoryName), ref _categoryName, value);
    }

    public CategoryTypes CategoryTypeName
    {
      get => _categoryTypeName;
      set => SetPropertyValue(nameof(CategoryTypeName), ref _categoryTypeName, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string CategoryColor
    {
      get => _categoryColor;
      set => SetPropertyValue(nameof(CategoryColor), ref _categoryColor, value);
    }

    [Size(SizeAttribute.DefaultStringMappingFieldSize)]
    public string CategoryIcon
    {
      get => _categoryIcon;
      set => SetPropertyValue(nameof(CategoryIcon), ref _categoryIcon, value);
    }

    [Association]
    public Incomes Incomes
    {
      get => _ıncomes;
      set => SetPropertyValue(nameof(Incomes), ref _ıncomes, value);
    }

    
    [Association]
    public Expenses Expenses
    {
      get => _expenses;
      set => SetPropertyValue(nameof(Expenses), ref _expenses, value);
    }

  }
}
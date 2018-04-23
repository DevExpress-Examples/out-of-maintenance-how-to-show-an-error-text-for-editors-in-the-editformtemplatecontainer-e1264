using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web.ASPxEditors;
using System.Collections.Generic;

namespace WebApplication12
{
    
   
    public partial class _Default : System.Web.UI.Page
    {

        protected Dictionary<GridViewColumn, string> errorList;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ASPxGridView1_RowValidating(object sender, DevExpress.Web.Data.ASPxDataValidationEventArgs e)
        {
            if (e.NewValues["CategoryName"].ToString().Length > 16)
            {
                GridViewDataColumn col = ((ASPxGridView)sender).Columns["CategoryName"] as GridViewDataColumn;
                e.Errors.Add(col, "The name is too long");
                
                
            }
            errorList = e.Errors;
        }

        protected void ShowFieldError(ASPxEdit templateEditor, GridViewDataColumn errorColumn)
        {
            if (errorList != null)
            {
                for (int i = 0; i < errorList.Count; i++)
                {
                    if (errorList.ContainsKey(errorColumn))
                    {
                        string errorText = errorList[errorColumn];
                        templateEditor.IsValid = false;
                        templateEditor.ValidationSettings.ErrorText = errorText;
                    }
                }
            }
        }

        protected void ASPxTextBox1_Load(object sender, EventArgs e)
        {
            GridViewDataColumn col = ASPxGridView1.Columns["CategoryName"] as GridViewDataColumn;
            ShowFieldError((sender as ASPxTextBox),col);
        }
    }
}

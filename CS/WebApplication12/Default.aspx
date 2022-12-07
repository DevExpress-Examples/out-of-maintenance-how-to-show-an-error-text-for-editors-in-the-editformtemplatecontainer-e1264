<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication12._Default" %>

<%@ register Assembly="DevExpress.Web.v15.1" Namespace="DevExpress.Web"
    TagPrefix="dxwgv" %>
<%@ register Assembly="DevExpress.Web.v15.1" Namespace="DevExpress.Web"
    TagPrefix="dxe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dxwgv:aspxgridview ID="ASPxGridView1" runat="server" AutoGenerateColumns="False"
            DataSourceID="AccessDataSource1" KeyFieldName="CategoryID" OnRowValidating="ASPxGridView1_RowValidating"><Columns>
<dxwgv:GridViewCommandColumn VisibleIndex="0">
<EditButton Visible="True"></EditButton>
</dxwgv:GridViewCommandColumn>
<dxwgv:GridViewDataTextColumn FieldName="CategoryID" ReadOnly="True" VisibleIndex="1">
<EditFormSettings Visible="False"></EditFormSettings>
</dxwgv:GridViewDataTextColumn>
<dxwgv:GridViewDataTextColumn FieldName="CategoryName" VisibleIndex="2"></dxwgv:GridViewDataTextColumn>
<dxwgv:GridViewDataTextColumn FieldName="Description" VisibleIndex="3"></dxwgv:GridViewDataTextColumn>
</Columns>
            <templates>
                <editform>
                    <table>
                      <tr>
                         <td><b>CategoryID:</b></td>
                         <td>
                             <dxe:aspxlabel ID="ASPxLabel1" runat="server" Text='<%#Eval("CategoryID") %>'>
                             </dxe:aspxlabel>
                         </td>
                      </tr>
                      <tr>
                      <td>
                        <b>Category Name:</b>
                      </td>
                      <td>
                          <dxe:aspxtextbox ID="ASPxTextBox1" runat="server" Width="170px" Text='<%#Bind("CategoryName") %>' OnLoad="ASPxTextBox1_Load">
                          </dxe:aspxtextbox>
                      </td>
                      </tr>
                      <tr>
                        <td>
                          <b>Description:</b>
                        </td>
                        <td>
                            <dxe:aspxtextbox ID="ASPxTextBox2" runat="server" Width="170px" Text='<%#Bind("Description") %>'>
                            </dxe:aspxtextbox>
                        </td>
                      </tr>
                    </table>
                    <dxwgv:aspxgridviewtemplatereplacement ReplacementType="EditFormUpdateButton" runat="server">
                    </dxwgv:aspxgridviewtemplatereplacement>
                    <dxwgv:aspxgridviewtemplatereplacement ReplacementType="EditFormCancelButton" runat="server">
                    </dxwgv:aspxgridviewtemplatereplacement>
                </editform>
            </templates>
</dxwgv:aspxgridview>
    
    </div>
        <asp:accessdatasource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
            SelectCommand="SELECT * FROM [Categories]"></asp:accessdatasource>
    </form>
</body>
</html>

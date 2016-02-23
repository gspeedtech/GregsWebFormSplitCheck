<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="GregsWebFormSplitCheck._Home" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>GREG&#39;S SPLIT CHECK (WEB FORM)</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Check Details
                <asp:GridView ID="gvCheck" OnRowDataBound="gvCheck_RowDataBound" AutoGenerateColumns="false"  runat="server" DataSourceID="odsCheck">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <%#Eval("Name") %>
                                <asp:GridView ID="gvCheckItems" runat="server"></asp:GridView>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </h2>
            <p> </p>
            <p> </p>
        </div>
        <div class="col-md-4">
            <h2>Totals By Party</h2>
            <p> </p>
            <p> </p>
        </div>
        <div class="col-md-4">
            <h2>Totals By Diner</h2>
            <p> </p>
            <p> </p>
        </div>
    </div>

    <asp:ObjectDataSource ID="odsCheck" runat="server" SelectMethod="GetCheck" TypeName="GregsCommon.CheckItem"></asp:ObjectDataSource>

</asp:Content>

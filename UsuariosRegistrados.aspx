<%@ Page Title="UsuariosRegistrados" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsuariosRegistrados.aspx.cs" Inherits="FormularioRegistro.aspx.UsuariosRegistrados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">

            <asp:GridView ID="gvUsuarios" runat="server" AutoGenerateColumns="False" DataKeyNames="id" OnSelectedIndexChanged="gvUsuarios_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="ID" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                    <asp:BoundField DataField="email" HeaderText="Email" />
                </Columns>
    </asp:GridView>


        </div>
    <</div>
       
       
    </div>
</asp:Content>

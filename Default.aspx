<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FormularioRegistro.aspx._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <head>
     <link rel="stylesheet" media="only screen and (max-width: 768px)" href="estilos.css">
    </head>

    <div class="jumbotron">
        <h1>Formulario Registro</h1> 

    </div> 
    <div class="form-group">
    <label for="name">Nombre:</label>
        <asp:TextBox ID="txtname" CssClass ="form-control" runat="server"></asp:TextBox>
        </div>

    <div class="form-group">
    <label for="lastname">Apellido:</label>
    <asp:TextBox ID="txtlastname" CssClass ="form-control" runat="server"></asp:TextBox>
    </div>

    <div class="form-group">
    <label for="dni">DNI:</label>
        <asp:TextBox ID="txtdni" CssClass ="form-control" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Falta DNI" ControlToValidate="txtdni" ></asp:RequiredFieldValidator>
    </div>

    <div class="form-group">
        <label>Pais de Nacimiento</label>
    <asp:DropDownList ID="DropDownList1" runat="server">
  
  <asp:ListItem Value="valor1">Argentina</asp:ListItem>
  <asp:ListItem Value="valor2">Brasil</asp:ListItem>
  <asp:ListItem Value="valor3">Chile</asp:ListItem>
   <asp:ListItem Value="valor3">Uruguay</asp:ListItem>
   </asp:DropDownList>


    </div>

    <div class="form-group">
        <label>Curso en Desarrollo:</label>
    <asp:RadioButtonList ID="miRadioButtonList" runat="server">
    <asp:ListItem Value="valor1">JAVA</asp:ListItem>
    <asp:ListItem Value="valor2">.NET</asp:ListItem>
    <asp:ListItem Value="valor3">Diseño UX/UI</asp:ListItem>
    </asp:RadioButtonList>


    </div>
    <div class="form-group">
        <label>Conocimientos:</label>
   <asp:CheckBoxList ID="CheckBoxList1" runat="server">
   <asp:ListItem>HTML</asp:ListItem>
   <asp:ListItem>Javascript</asp:ListItem>
   <asp:ListItem>JQuery</asp:ListItem>
   <asp:ListItem>CSS</asp:ListItem>
   <asp:ListItem>.NET</asp:ListItem>
   <asp:ListItem>SQL Server</asp:ListItem>
</asp:CheckBoxList>

    </div>
   
<div class="form-group">
    <label for="email">Email:</label>
    <asp:TextBox ID="email" CssClass="form-control" runat="server"></asp:TextBox>
</div> 

    <div class="form-group">
    <label for="birthdate">Fecha de nacimiento:</label>
        <asp:TextBox ID="Fechanac" CssClass="form-control" runat="server"></asp:TextBox>
    </div> 

    <div class="form-group">
    <label for="message">Otros conocimientos:</label>
    <asp:TextBox ID="otros" CssClass="form-control" runat="server"></asp:TextBox>
    </div> 

    <div class="form-group">
    <label for="password">Contraseña: </label>
        <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
    </div> 

    <div class="form-group">
    <label for="confirm_password">Confirmar contraseña:</label>
    <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
    </div> 
     

      
       <div class="form-group">             
            <asp:Button ID="Enviar" runat="server" Text="Enviar" />
            <asp:Button ID="Cancelar" runat="server" Text="Cancelar" />

        </div> 

   <div class="row">
        <div class="col-md-4">
        </div>
        <div class="col-md-4">
        </div>
        <div class="col-md-4">
        </div>
    </div>

    
   
</asp:Content>

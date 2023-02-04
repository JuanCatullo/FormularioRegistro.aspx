<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FormularioRegistro.aspx._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <head>
     <link rel="stylesheet" media="only screen and (max-width: 768px)" href="estilos.css">
     </head>


    <div class="container-fluid"></div>

    <div class="panel panel-primary">

         <div class="panel-heading">
            <h3 class="panel-title">Formulario Registro</h3>
        </div>

    
     <div class="form-group">
    <label for="name">Nombre:</label>
        <asp:TextBox ID="txtname" CssClass ="form-control" runat="server" ValidationGroup="Registro"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="form-control" runat="server" ControlToValidate="txtname" ValidationGroup="Registro" ErrorMessage="Falta Nombre" Display="None" ></asp:RequiredFieldValidator>
        </div>

    <div class="form-group">
    <label for="lastname">Apellido:</label>
    <asp:TextBox ID="txtlastname" CssClass ="form-control" runat="server" ValidationGroup="Registro"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtlastname" ValidationGroup="Registro" ErrorMessage="Falta Apellido" Display="None"  ></asp:RequiredFieldValidator>
    </div>

    <div class="form-group">
    <label for="dni">DNI:</label>
        <asp:TextBox ID="txtdni" CssClass ="form-control" runat="server" ValidationGroup="Registro"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtdni" ValidationGroup="Registro" ErrorMessage="Falta DNI" Display="None"  ></asp:RequiredFieldValidator>
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
    </asp:RadioButtonList> <br>


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
   </asp:CheckBoxList> <br>

    </div>
   
<div class="form-group">
    <label for="email">Email:</label>
    <asp:TextBox ID="email" CssClass="form-control" runat="server" ControlToValidate="email" ValidationGroup="Registro" TextMode="Email" ErrorMessage="Falta Email"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="email" ValidationGroup="Registro" ErrorMessage="Falta Ingresar Email" Display="None"  ></asp:RequiredFieldValidator>
</div> 

    <div class="form-group">
    <label for="birthdate">Fecha de nacimiento:</label>
        <asp:TextBox ID="Fechanac" CssClass="form-control" runat="server" ControlToValidate="fechanac" ValidationGroup="Registro" ErrorMessage="Falta Fecha de Nacimiento"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Fechanac" ValidationGroup="Registro" ErrorMessage="Falta Ingresar Fecha de Nacimiento" Display="None"  ></asp:RequiredFieldValidator>
    </div> 

    <div class="form-group">
    <label for="message">Otros conocimientos:</label> 
    <asp:TextBox ID="otros" CssClass="form-control" runat="server" ControlToValidate="otros" ValidationGroup="Registro"></asp:TextBox>
    </div> 

    <div class="form-group">
    <label for="password">Contraseña: </label>
        <asp:TextBox ID="password" CssClass="form-control" runat="server" ControlToValidate="password" TextMode="Password" ValidationGroup="Registro" ErrorMessage="Falta Contraseña"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="password" ValidationGroup="Registro" ErrorMessage="Falta Ingresar Contraseña" Display="None"  ></asp:RequiredFieldValidator>
    </div> 

    <div class="form-group">
    <label for="confirm_password">Confirmar contraseña:</label>
    <asp:TextBox ID="confirm_password" CssClass="form-control" runat="server" ControlToValidate="confirm_password" TextMode="Password" ValidationGroup="Registro"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="confirm_password" ValidationGroup="Registro" ErrorMessage="Falta Confirmar Contraseña" Display="None"  ></asp:RequiredFieldValidator>
    </div> 
     

      
       <div class="form-group">
           
            <asp:Button ID="Enviar" runat="server" Text="Enviar" OnClick="Enviar_Click" ValidationGroup="Registro" />

            <asp:Button ID="Cancelar" runat="server" Text="Cancelar" />

            <asp:Label ID="lblerror" runat="server" Text="" ValidationGroup="Registro"></asp:Label>

    </div>

    <asp:ValidationSummary ID="valSummary1" runat="server" ValidationGroup="Registro" ShowMessageBox="true" ShowSummary="true"></asp:ValidationSummary>

   <div class="row">
        <div class="col-md-4">
        </div>
        <div class="col-md-4">
        </div>
        <div class="col-md-4">
        </div>
    </div>

    
   
     </div>
</asp:Content>

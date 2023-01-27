<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FormularioRegistro.aspx._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <head>
     <link href="css/styles.css" rel="stylesheet" type="text/css" />
    </head>

    <div class="jumbotron">
        <h1>Formulario Registro</h1> 
        <p class="lead"></p> 
        <p></p> 

    </div> <br>
    <div class="form-group">
    <label for="name">Nombre:</label>
    <input type="text" class="form-control" id="name" name="name">
        </div>

    <div class="form-group">
    <label for="lastname">Apellido:</label>
    <input type="text" class="form-control" id="lastname" name="lastname">
</div>

    <div class="form-group">
    <label for="dni">DNI:</label>
    <input type="text" class="form-control" id="dni" name="dni" maxlength="8" >
</div>

    <div class="form-group">
    <label for="exampleFormControlSelect1">Lugar de Nacimiento</label>
    <select class="form-control" id="exampleFormControlSelect1" name="exampleFormControlSelect1">
        <option>Argentina</option>
        <option>Brasil</option>
        <option>Chile</option>
        <option>Uruguay</option>
    </select>
</div>

    <div class="form-group">
    <label>Curso en Desarrollo:</label>
    <div class="form-check">
        &nbsp;<label class="form-check-label" for="exampleRadios1"><input class="form-check-input" type="radio" name="exampleRadios" id="exampleRadios1" value="option4" checked="true">JAVA
        </label>
    </div>
    <div class="form-check">
        <input class="form-check-input" type="radio" name="exampleRadios" id="exampleRadios2" value="option2">
        <label class="form-check-label" for="exampleRadios2">
            .NET
        </label>
    </div>
    <div class="form-check">
        <input class="form-check-input" type="radio" name="exampleRadios" id="exampleRadios3" value="option3">
        <label class="form-check-label" for="exampleRadios3">
            Diseño UX/UI
        </label> 
    </div> <br>


        <form>
            <label>Conocimientos</label> <br>
  <label>
    <input type="checkbox" name="option1" value="value1"> HTML
  </label>
  <br>
  <label>
    <input type="checkbox" name="option2" value="value2"> Javascript
  </label>
  <br>
  <label>
    <input type="checkbox" name="option3" value="value3"> JQuery
  </label>
  <br>
  <label>
    <input type="checkbox" name="option4" value="value4"> CSS
  </label>
  <br>
  <label>
    <input type="checkbox" name="option5" value="value5"> .NET
  </label> <br>
           
</form> <br>


<div class="form-group">
    <label for="email">Email:</label>
    <input type="email" class="form-control" id="email" name="email">
</div> <br>

    <div class="form-group">
    <label for="birthdate">Fecha de nacimiento:</label><input type="date" class="form-control" id="birthdate" name="birthdate">&nbsp;
</div> <br>

    <div class="form-group">
    <label for="message">Otros conocimientos:</label>
    <textarea class="form-control" rows="5" id="message" name="message"></textarea>
</div> <br>

    <div class="form-group">
    <label for="password">Contraseña: </label>
&nbsp;<input type="password" class="form-control" id="password" name="password">
</div> <br>

<div class="form-group">
    <label for="confirm_password">Confirmar contraseña:</label>
    <input type="password" class="form-control" id="confirm_password" name="confirm_password">
    </div> <br>

       

        <div style="height: 42px">
             
        
    <input type="button" value="Enviar" id="btn1" onclick="miFuncion()" /> 

    <input type="button" value="Cancelar" id="btn2" onclick="miFuncion()" /> 

        </div> 

  
        

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

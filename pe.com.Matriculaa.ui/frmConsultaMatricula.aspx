<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmConsultaMatricula.aspx.cs" Inherits="pe.com.Matriculaa.ui.frmConsultaMatricula" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
<body>
    <form id="form1" runat="server" CssClass="row g-3 needs-validation" novalidate>
         <asp:Label ID="Label1" runat="server" Text="Consulta Matricula"></asp:Label><br />
      
           <div class="col-md-4">
       <asp:Label ID="Label2" CssClass="form-label" runat="server" Text="ID"></asp:Label>
        <asp:TextBox ID="txtCodE"  CssClass="form-control" runat="server" ></asp:TextBox>
           </div class="valid-feedback">
        <div class="col-md-4">
         <asp:Label ID="Label3"  CssClass="form-label" runat="server"  Text="Nombre"></asp:Label>
 <asp:TextBox ID="txtName" CssClass="form-control" runat="server"></asp:TextBox>
        </div class="valid-feedback">
        <br />
        <div class="col-md-4">
            <asp:Label ID="Label4" CssClass="form-label" runat="server" Text="Apellido"></asp:Label>
 <asp:TextBox ID="txtLName" CssClass="form-control" runat="server"></asp:TextBox><br />
       </div class="valid-feedback">
            <asp:Label ID="Label11" CssClass="form-label" runat="server" Text="DNI"></asp:Label>
        <asp:TextBox ID="txtDNI" CssClass="form-control" runat="server"></asp:TextBox>
         <asp:Label ID="Label8" CssClass="form-label" runat="server" Text="Telefono"></asp:Label>
 <asp:TextBox ID="txtFono" CssClass="form-control" runat="server"></asp:TextBox><br />
         <asp:Label ID="Label9" CssClass="form-label" runat="server" Text="Correo electronico"></asp:Label>
 <asp:TextBox ID="txtCorreo" CssClass="form-control" runat="server" ></asp:TextBox>
         <asp:Label ID="Label6" CssClass="form-label" runat="server"  Text="Sexo"></asp:Label>
        <asp:DropDownList ID="ddlSexo"  Cssclass="form-select" runat="server">
        </asp:DropDownList>
        <br />
         <asp:Label ID="Label12" runat="server" CssClass="form-label" Text="Grado"></asp:Label>
        <asp:DropDownList ID="ddlGrado" Cssclass="form-select" runat="server" >
</asp:DropDownList>
         <asp:Label ID="Label13" runat="server" Cssclass="form-label" Text="Nivel"></asp:Label>
        <asp:DropDownList ID="ddlNivel" Cssclass="form-select" runat="server" AutoPostBack="true" >
        </asp:DropDownList> <br />
        <asp:Label ID="Label7" CssClass="form-label" runat="server" Text="Direccion"></asp:Label>
<asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
   <asp:Label ID="Label14" CssClass="form-label" runat="server" Text="Distrito"></asp:Label>
 <asp:DropDownList ID="ddlDistritos" runat="server">
   
</asp:DropDownList>
        <br />
          
        <asp:Label ID="Label15" CssClass="form-label" runat="server" Text="Estado"></asp:Label>
        <asp:CheckBox ID="chkEst" runat="server" Text="Habilitado"/>
        <br />
 <asp:Label ID="Label10" runat="server" CssClass="form-label" Text="Fecha de inscripcion"></asp:Label>
        <asp:Calendar ID="cFechaIns"  class="mb-3" runat="server" ></asp:Calendar> 
         <asp:Label ID="Label5" CssClass="form-label" runat="server" Text="Fecha de nacimiento"></asp:Label>
        <asp:Calendar ID="cFechaNac" runat="server" Width="236px"></asp:Calendar> <br />
      </div>

        <div>
            <asp:Label ID="Label16" CssClass="form-label" runat="server" Text="Id Apoderado"></asp:Label>
            <asp:TextBox ID="txtCodA" runat="server"></asp:TextBox> <br />

            <asp:Label ID="Label17" CssClass="form-label" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNamEA" runat="server"></asp:TextBox>

            <asp:Label ID="Label18" CssClass="form-label" runat="server" Text="Apellido"></asp:Label>
            <asp:TextBox ID="txtNameLA" runat="server"></asp:TextBox> <br />

            <asp:Label ID="Label22" CssClass="form-label" runat="server" Text="Telefono"></asp:Label>
             <asp:TextBox ID="txtFonoA" runat="server"></asp:TextBox>

            <asp:Label ID="Label23" CssClass="form-label" runat="server" Text="Correo electronico"></asp:Label>
             <asp:TextBox ID="txtCorreoA" runat="server"></asp:TextBox> <br />
            
            <asp:Label ID="Label20" CssClass="form-label" runat="server" Text="DNI"></asp:Label>
             <asp:TextBox ID="txtDniA" runat="server"></asp:TextBox>

            <asp:Label ID="Label21" CssClass="form-label" runat="server" Text="Direccion"></asp:Label>
             <asp:TextBox ID="txtDireA" runat="server"></asp:TextBox> <br />

              <asp:Label ID="Label24" CssClass="form-label" runat="server" Text="Estado"></asp:Label>
              <asp:CheckBox ID="chkEstA" runat="server" Text="Habilitado"/>
            <br />
            <asp:Label ID="Label19" CssClass="form-label" runat="server" Text="Fecha Nacimiento"></asp:Label>
<asp:Calendar ID="CfechaNacA" runat="server"></asp:Calendar>
        </div>

        <div>
            <asp:Label ID="Label26" CssClass="form-label" runat="server" Text="Caracteristicas de la Matricula"></asp:Label> <br />
                      <asp:Label ID="Label28" CssClass="form-label" runat="server" Text="ID Matricula"></asp:Label>
<asp:TextBox ID="txtIdMat" runat="server" ></asp:TextBox><br />
            <asp:Label ID="Label25" runat="server" Text="Estado de matricula"></asp:Label>
                  <asp:DropDownList ID="ddlestMat" runat="server">
               </asp:DropDownList>
            <asp:Label ID="Label27" CssClass="form-label" runat="server" Text="Tipo de vacante"></asp:Label>
            <asp:TextBox ID="txtVacante" runat="server"></asp:TextBox>
            <asp:CheckBox ID="chkEstMat" runat="server" Text="Visible"/>
        </div> <br />
        <asp:Button ID="BtnNew" runat="server" Text="Nuevo" OnClick="BtnNew_Click" />
        <asp:Button ID="BtnOt" runat="server" Text="Registro" OnClick="BtnOt_Click" />
        <asp:Button ID="BtnUp" runat="server" Text="Actualizar" OnClick="BtnUp_Click" />
        <asp:Button ID="BtnDel" runat="server" Text="Eliminar" OnClick="BtnDel_Click" />
        <asp:Button ID="BtnSer" runat="server" Text="Buscar" OnClick="BtnSer_Click" />
        <asp:GridView ID="dgvStu" CssClass="table"  runat="server" AutoGenerateColumns="false" OnRowCommand="dgvStu_RowCommand">
          <%--agregando columnas--%>
            <Columns>
                <asp:BoundField DataField="IdMatricula" HeaderText="Código Matrícula" />
<asp:BoundField DataField="NombreEstudiante" HeaderText="Nombre Estudiante" />
<asp:BoundField DataField="ApellidoEstudiante" HeaderText="Apellido Estudiante" />
<asp:BoundField DataField="NombreApoderado" HeaderText="Apoderado" />
<asp:BoundField DataField="FechaMatricula" HeaderText="Fecha de matrícula" />
<asp:BoundField DataField="TipoVacante" HeaderText="Tipo Vacante" />
<asp:BoundField DataField="NombreNivel" HeaderText="Nivel" />
<asp:BoundField DataField="NombreGrado" HeaderText="Grado" />
<asp:BoundField DataField="EstadoMatricula" HeaderText="Estado Matrícula" />

                <%--agregamos una plantilla para el estado--%>
                <asp:TemplateField HeaderText="Visible">
                    <ItemTemplate>
                       <%# (char)Eval("Visible") == '1' ? "V" : "s" %>


                    </ItemTemplate>
                </asp:TemplateField>
                <%--agregamos un boton para seleccionar la fila--%>
                <asp:ButtonField Text="Seleccionar" CommandName="Seleccionar" />
            </Columns>
        </asp:GridView>
        
    </form>
</body>
</html>


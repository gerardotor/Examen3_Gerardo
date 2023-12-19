<%@ Page Title="" Language="C#" MasterPageFile="~/Encuesta.Master" AutoEventWireup="true" CodeBehind="Realizaencuesta.aspx.cs" Inherits="BD_Gerardo.Realizaencuesta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Encuesta Partidos políticos</h2>

    <div>
        <h3>Agregar Encuesta</h3>
        <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre" OnTextChanged="txtNombre_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtCorreoElectronico" runat="server" placeholder="Correo Electrónico" OnTextChanged="txtCorreoElectrpnico_TextChanged"></asp:TextBox>
        <asp:TextBox ID="txtEdad" runat="server" placeholder="Edad" OnTextChanged="txtEdad_TextChanged"></asp:TextBox>
        <asp:Button ID="btnGuardarencuesta" runat="server" Text="Guardar Encuesta" OnClick="btnGuardarEncuesta_Click" />
    </div>

    <hr />

    <div>
        <h3>Listado de Encuesta</h3>
        <asp:GridView ID="gridEncuesta" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gridEncuesta_SelectedIndexChanged">
            <Columns>
                
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="CorreoElectronico" HeaderText="Correo Electrónico" />
                <asp:BoundField DataField="Edad" HeaderText="Edad" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
    </div>
<div>
</div>  

</asp:Content>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cancela.aspx.cs" Inherits="Consultorio.Cancela" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Pagina4.css" />
    <title></title>
</head>
<body>
    <header id="trinta"><img alt="" src="Imagem/01.jpg" /></header>
    <form id="form1" runat="server">
        <fieldset> PESQUISA PACIENTE<br /><br />

        <asp:Label ID="Label1" runat="server" Text="NUMERO DA CARTEIRA:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="CPF:"></asp:Label>
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" Width="246px"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="LOCALZAR" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="246px"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button2" runat="server" Text="LOCALZAR" />
&nbsp;</fieldset>
        <br />
        
        <fieldset>DADOS DO PACIENTE<br /><br />
        <asp:Label ID="Label3" runat="server" Text="NOME COMPLETO:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox3" runat="server" Width="499px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="ENDERECO:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox4" runat="server" Width="553px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="TELEFONE RESIDENCIAL:"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" Width="141px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Text="CELULAR:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox6" runat="server" Width="181px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="DATA CONSULTA:"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" Width="187px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label8" runat="server" Text="HORARIO:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox8" runat="server" Width="180px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="EMAIL:"></asp:Label>
        <asp:TextBox ID="TextBox9" runat="server" Width="597px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="CANCELAR CONSULTA" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <a href="WebForm1.aspx"><input type="button" value="RETORNAR" /></a>
        <br />
        <br />
      
    </fieldset>
    </div>
    </form>
    <footer id="trintaum"><img alt="" src="Imagem/01.jpg" /></footer>
</body>
</html>

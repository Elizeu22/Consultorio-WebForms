<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Consultorio.Formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Pagina3.css" />
    <script type="text/javascript" src="Expressao_Regular1.js"></script>
    <style type="text/css">
        #vinte {
            font-style: italic;
            text-align: left;
        }
    </style>
</head>
<body>
    <header id="vinte"><img  alt="" src="Imagem/01.jpg" /></header>
    
    
    <form id="form1" runat="server">
        <fieldset id="vinteum">DATAS DISPONIVEIS

            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="DATAS"></asp:Label>
&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>NOV 2014</asp:ListItem>
                <asp:ListItem>DEZ 2014</asp:ListItem>
                <asp:ListItem>JAN 2015</asp:ListItem>
                <asp:ListItem>FEV 2015</asp:ListItem>
                <asp:ListItem>MAR 2015</asp:ListItem>
                <asp:ListItem>ABR 2015</asp:ListItem>
                <asp:ListItem>MAI 2015</asp:ListItem>
                <asp:ListItem>JUN 2015</asp:ListItem>
                <asp:ListItem>JUL 2015</asp:ListItem>
                <asp:ListItem>AGO 2015</asp:ListItem>
                <asp:ListItem>SET 2015</asp:ListItem>
                <asp:ListItem>OUT 2015</asp:ListItem>
                <asp:ListItem>NOV 2015</asp:ListItem>
                <asp:ListItem>DEZ 2015</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="VERFICAR" />
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label10" runat="server" Text="DIA"></asp:Label>
            &nbsp;&nbsp;<asp:DropDownList ID="DropDownList6" runat="server">
            </asp:DropDownList>
            &nbsp;&nbsp; &nbsp; <asp:Button ID="Button5" runat="server" Text="HORARIOS ALOCADOS" OnClick="Button5_Click" Width="218px" />
            &nbsp;
            <asp:DropDownList ID="DropDownList5" runat="server">
            </asp:DropDownList>

            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;

        </fieldset>
        <br />
        <fieldset>CADASTRAR PACIENTE
            <br />
            <br />
            <asp:Label ID="Label2" runat="server"  Text="NUMERO CARTEIRINHA:"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Placeholder="SOMENTE NUMEROS" Width="482px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label11" runat="server" Text="CPF:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox10" runat="server"  Placeholder="SOMENTE NUMEROS" Width="633px" OnTextChanged="TextBox10_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="NOME COMPLETO:"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" placeholder="NOME COMPLETO" Width="521px" OnTextChanged="TextBox3_TextChanged" ></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="TELEFONE RESIDENCIAL:"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"  placeholder="0000-0000" Width="189px" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="CELULAR:"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" placeholder="0000-00000" Width="264px" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="DATA NASCIMENTO:"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server" Placeholder="__/__/____" Width="137px" OnTextChanged="TextBox6_TextChanged"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label7" runat="server" Text="DATA CONSULTA:"></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownList3" runat="server">
                <asp:ListItem>NOV 2014</asp:ListItem>
                <asp:ListItem>DEZ 2014</asp:ListItem>
                <asp:ListItem>JAN 2015</asp:ListItem>
                <asp:ListItem>FEV 2015</asp:ListItem>
                <asp:ListItem>MAR 2015</asp:ListItem>
                <asp:ListItem>ABR 2015</asp:ListItem>
                <asp:ListItem>MAI 2015</asp:ListItem>
                <asp:ListItem>JUN 2015</asp:ListItem>
                <asp:ListItem>JUL 2015</asp:ListItem>
                <asp:ListItem>AGO 2015</asp:ListItem>
                <asp:ListItem>SET 2015</asp:ListItem>
                <asp:ListItem>OUT 2015</asp:ListItem>
                <asp:ListItem>NOV 2015</asp:ListItem>
                <asp:ListItem>DEZ 2015</asp:ListItem>
            </asp:DropDownList>
            &nbsp;
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="VERIFICAR" Width="90px" OnClientClick="expressao"/>
&nbsp;<asp:DropDownList ID="DropDownList4" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="HORARIO:"></asp:Label>
&nbsp;&nbsp;<asp:DropDownList ID="DropDownList2" runat="server" style="margin-left: 0px; margin-bottom: 0px">
                <asp:ListItem>09:00</asp:ListItem>
                <asp:ListItem>09:20</asp:ListItem>
                <asp:ListItem>09:40</asp:ListItem>
                <asp:ListItem>10:00</asp:ListItem>
                <asp:ListItem>10:20</asp:ListItem>
                <asp:ListItem>10:40</asp:ListItem>
                <asp:ListItem>11:00</asp:ListItem>
                <asp:ListItem>11:40</asp:ListItem>
                <asp:ListItem>12:00</asp:ListItem>
                <asp:ListItem>13:40</asp:ListItem>
                <asp:ListItem>14:00</asp:ListItem>
                <asp:ListItem>14:20</asp:ListItem>
                <asp:ListItem>14:40</asp:ListItem>
                <asp:ListItem>15:00</asp:ListItem>
                <asp:ListItem>15:20</asp:ListItem>
                <asp:ListItem>15:40</asp:ListItem>
                <asp:ListItem>16:00</asp:ListItem>
                <asp:ListItem>16:20</asp:ListItem>
                <asp:ListItem>16:40</asp:ListItem>
                <asp:ListItem>17:00</asp:ListItem>
                <asp:ListItem>17:20</asp:ListItem>
                <asp:ListItem>17:40</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;<asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="CONFERIR DATA" Width="144px" />
            &nbsp;
            <asp:DropDownList ID="DropDownList7" runat="server">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;<asp:Label ID="Label9" runat="server" Text="EMAIL:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox9" runat="server" placeholder="xxx@xxx.com" Width="286px" OnTextChanged="TextBox9_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="GRAVAR DADOS" OnClick="Button3_Click" OnClientClick="Expressao_Regular1.js"/>
&nbsp;
            <asp:Button ID="Button4" runat="server" Text="LIMPAR DADOS" />
            &nbsp;
            <a href="WebForm1.aspx"><input type="button" value="RETORNAR" /></a>
            <br />
            <br />
            <br />
        </fieldset>
    </form>
    <footer id="vinteum"><img alt="" src="Imagem/01.jpg" /></footer>
</body>
</html>

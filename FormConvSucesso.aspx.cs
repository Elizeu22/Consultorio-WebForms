using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Consultorio
{
    public partial class FormConvSucesso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string conexao = @"Server=Localhost;Database=Consultorio;Trusted_Connection=true";
            SqlConnection conecta1 = new SqlConnection(conexao);

            conecta1.Open();

            SqlCommand acha = new SqlCommand("select distinct DtConsulta,Dia_Consulta from Paciente_Clinica_Sucesso where DtConsulta='" + DropDownList1.Text + "'", conecta1);

            DropDownList3.DataTextField = "Dia_Consulta";
            DropDownList3.DataValueField = "Dia_Consulta";
            DropDownList3.DataSource = acha.ExecuteReader();
            DropDownList3.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            if (TextBox2.Text == "")
            {
                Response.Write("<script>alert('O CAMPO NUMERO CARTEIRA  NAO FOI PREENCHIDO')</script>");
                Response.Redirect("http://localhost:50054/FormConvSucesso.aspx");
                Response.Write("<script>alert('O CAMPO NUMERO CARTEIRA  NAO FOI PREENCHIDO')</script>");
            }

            if (TextBox10.Text == "")
            {
                Response.Write("<script>alert('O CAMPO CPF  NAO FOI PREENCHIDO')</script>");
                Response.Redirect("http://localhost:50054/FormConvSucesso.aspx");
            }

            if (TextBox3.Text == "")
            {
                Response.Write("<script>alert('O CAMPO NOME COMPLETO NAO FOI PREENCHIDO')</script>");
                Response.Redirect("http://localhost:50054/FormConvSucesso.aspx");
            }

            if (TextBox4.Text == "")
            {
                Response.Write("<script>alert('O CAMPO TELEFONE  NAO FOI PREENCHIDO')</script>");
                Response.Redirect("http://localhost:50054/FormConvSucesso.aspx");
            }


            if (TextBox5.Text == "")
            {
                Response.Write("<script>alert('O CAMPO CELULAR  NAO FOI PREENCHIDO')</script>");
                Response.Redirect("http://localhost:50054/FormConvSucesso.aspx");
            }


            if (TextBox6.Text == "")
            {
                Response.Write("<script>alert('O CAMPO DATA DE NASCIMENTO  NAO FOI PREENCHIDO')</script>");
                Response.Redirect("http://localhost:50054/FormConvSucesso.aspx");
            }

            if (TextBox9.Text == "")
            {
                Response.Write("<script>alert('O CAMPO EMAIL  NAO FOI PREENCHIDO')</script>");
                Response.Redirect("http://localhost:50054/FormConvSucesso.aspx");
            }




            string connectionString = @"Server=Localhost;Database=Consultorio;Trusted_Connection=true";
            SqlConnection SqlConn = new SqlConnection(connectionString);

            SqlConn.Open();

            long cpf = long.Parse(TextBox10.Text);
            long carteira = long.Parse(TextBox2.Text);

            SqlCommand novo = new SqlCommand("Insert into Paciente_Clinica_Sucesso values('" + carteira + "','" + cpf + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + DropDownList5.Text + "','" + DropDownList6.Text + "','" + DropDownList2.Text + "','" + TextBox9.Text + "')", SqlConn);
            novo.ExecuteNonQuery();
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";

            Response.Write("<script>alert('DADOS GRAVADOS COM SUCESSO')</script>");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=Localhost;Database=Consultorio;Trusted_Connection=true";
            SqlConnection conexao2 = new SqlConnection(connectionString);

            conexao2.Open();

            SqlCommand acha = new SqlCommand("select Hora,Dia_Consulta from Paciente_Clinica_Sucesso where Dia_Consulta='" + DropDownList3.Text + "'", conexao2);

            DropDownList4.DataTextField = "Hora";
            DropDownList4.DataValueField = "Hora";
            DropDownList4.DataSource = acha.ExecuteReader();
            DropDownList4.DataBind();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string conexao = @"Server=Localhost;Database=Consultorio;Trusted_Connection=true";
            SqlConnection conecta1 = new SqlConnection(conexao);

            conecta1.Open();

            SqlCommand acha = new SqlCommand("select mes,data from data_Sucesso where mes='" + DropDownList5.Text + "'", conecta1);

            DropDownList6.DataTextField = "data";
            DropDownList6.DataValueField = "data";
            DropDownList6.DataSource = acha.ExecuteReader();
            DropDownList6.DataBind();
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            Regex expressao7 = new Regex(@"^[0-9]");
            if (!expressao7.IsMatch(TextBox2.Text))
            {

                System.Threading.Thread.Sleep(9000);

                Response.Redirect("http://localhost:50054/FormConvSucesso.aspx");
            }
        }

        protected void TextBox10_TextChanged(object sender, EventArgs e)
        {
            Regex expressao8 = new Regex(@"^[0-9]");
            if (!expressao8.IsMatch(TextBox10.Text))
            {

                System.Threading.Thread.Sleep(9000);

                Response.Redirect("http://localhost:50054/FormConvSucesso.aspx");
            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            Regex expressao1 = new Regex(@"^[A-Z]");
            if (!expressao1.IsMatch(TextBox3.Text))
            {

                System.Threading.Thread.Sleep(9000);

                Response.Redirect("http://localhost:50054/FormConvSucesso.aspx");
            }
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            Regex expressao3 = new Regex(@"^[0-9]");
            if (!expressao3.IsMatch(TextBox4.Text))
            {

                System.Threading.Thread.Sleep(9000);

                Response.Redirect("http://localhost:50054/FormConvSucesso.aspx");
            }
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {
            Regex expressao4 = new Regex(@"^[0-9]");
            if (!expressao4.IsMatch(TextBox5.Text))
            {

                System.Threading.Thread.Sleep(9000);

                Response.Redirect("http://localhost:50054/FormConvSucesso.aspx");
            }
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {
            Regex data = new Regex(@"^[0-9]{2}/[0-9]{2}/[0-9]{4}");
            if (!data.IsMatch(TextBox6.Text))
            {

                System.Threading.Thread.Sleep(9000);

                Response.Redirect("http://localhost:50054/FormConvSucesso.aspx");
            }
        }

        protected void TextBox9_TextChanged(object sender, EventArgs e)
        {
            Regex email = new Regex(@"[^@]*@[^@]*");
            if (!email.IsMatch(TextBox9.Text))
            {

                System.Threading.Thread.Sleep(9000);

                Response.Redirect("http://localhost:50054/FormConvSucesso.aspx");
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=Localhost;Database=Consultorio;Trusted_Connection=true";
            SqlConnection conexao2 = new SqlConnection(connectionString);

            conexao2.Open();

            SqlCommand acha = new SqlCommand("select distinct DtConsulta,Dia_Consulta from Paciente_Clinica_Sucesso where hora ='" + DropDownList2.Text + "' ", conexao2);

            DropDownList7.DataTextField = "Dia_Consulta";
            DropDownList7.DataValueField = "Dia_Consulta";
            DropDownList7.DataSource = acha.ExecuteReader();
            DropDownList7.DataBind();
        }
    }
}
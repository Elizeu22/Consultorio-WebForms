using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections;

namespace Consultorio
{
    public partial class Formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


        }


        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string conexao = @"Server=Localhost;Database=Consultorio;Trusted_Connection=true";
            SqlConnection conecta = new SqlConnection(conexao);

            conecta.Open();

            SqlCommand acha = new SqlCommand("select mes,data from dataIlha where mes='" + DropDownList3.Text + "'", conecta);

            DropDownList4.DataTextField = "data";
            DropDownList4.DataValueField = "data";
            DropDownList4.DataSource = acha.ExecuteReader();
            DropDownList4.DataBind();




        }







        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "")
            {
                Response.Write("<script>alert('O CAMPO NUMERO CARTEIRA  NAO FOI PREENCHIDO')</script>");
                Response.Redirect("http://localhost:50054/Formulario.aspx");
                Response.Write("<script>alert('O CAMPO NUMERO CARTEIRA  NAO FOI PREENCHIDO')</script>");
            }

            if (TextBox10.Text == "")
            {
                Response.Write("<script>alert('O CAMPO CPF  NAO FOI PREENCHIDO')</script>");
                Response.Redirect("http://localhost:50054/Formulario.aspx");
            }

            if (TextBox3.Text == "")
            {
                Response.Write("<script>alert('O CAMPO NOME COMPLETO NAO FOI PREENCHIDO')</script>");
                Response.Redirect("http://localhost:50054/Formulario.aspx");
            }

            if (TextBox4.Text == "")
            {
                Response.Write("<script>alert('O CAMPO TELEFONE  NAO FOI PREENCHIDO')</script>");
                Response.Redirect("http://localhost:50054/Formulario.aspx");
            }


            if (TextBox5.Text == "")
            {
                Response.Write("<script>alert('O CAMPO CELULAR  NAO FOI PREENCHIDO')</script>");
                Response.Redirect("http://localhost:50054/Formulario.aspx");
            }


            if (TextBox6.Text == "")
            {
                Response.Write("<script>alert('O CAMPO DATA DE NASCIMENTO  NAO FOI PREENCHIDO')</script>");
                Response.Redirect("http://localhost:50054/Formulario.aspx");
            }

            if (TextBox9.Text == "")
            {
                Response.Write("<script>alert('O CAMPO EMAIL  NAO FOI PREENCHIDO')</script>");
                Response.Redirect("http://localhost:50054/Formulario.aspx");
            }


            string connectionString = @"Server=Localhost;Database=Consultorio;Trusted_Connection=true";
            SqlConnection SqlConn = new SqlConnection(connectionString);

            SqlConn.Open();

            long cpf = long.Parse(TextBox10.Text);
            long carteira = long.Parse(TextBox2.Text);

            SqlCommand novo = new SqlCommand("Insert into Paciente_Clinica_Ilha values('" + carteira + "','" + cpf + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + DropDownList3.Text + "','" + DropDownList4.Text + "','" + DropDownList2.Text + "','" + TextBox9.Text + "')", SqlConn);
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

            SqlCommand acha = new SqlCommand("select distinct Hora,Dia_Consulta from Paciente_Clinica_Ilha where Dia_Consulta ='" + DropDownList6.Text + "' ", conexao2);

            DropDownList5.DataTextField = "Hora";
            DropDownList5.DataValueField = "Hora";
            DropDownList5.DataSource = acha.ExecuteReader();
            DropDownList5.DataBind();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string conexao = @"Server=Localhost;Database=Consultorio;Trusted_Connection=true";
            SqlConnection conecta = new SqlConnection(conexao);

            conecta.Open();

            SqlCommand acha = new SqlCommand("select distinct DtConsulta,Dia_Consulta from Paciente_Clinica_Ilha where DtConsulta='" + DropDownList1.Text + "'", conecta);

            DropDownList6.DataTextField = "Dia_Consulta";
            DropDownList6.DataValueField = "Dia_Consulta";
            DropDownList6.DataSource = acha.ExecuteReader();
            DropDownList6.DataBind();

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            Regex expressao1 = new Regex(@"^[A-Z]");
            if (!expressao1.IsMatch(TextBox3.Text))
            {

                System.Threading.Thread.Sleep(9000);

                Response.Redirect("http://localhost:50054/Formulario.aspx");
            }

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {


            Regex expressao7 = new Regex(@"^[0-9]");
            if (!expressao7.IsMatch(TextBox2.Text))
            {

                System.Threading.Thread.Sleep(9000);

                Response.Redirect("http://localhost:50054/Formulario.aspx");
            }


        }



        protected void TextBox9_TextChanged(object sender, EventArgs e)
        {
            Regex email = new Regex(@"[^@]*@[^@]*");
            if (!email.IsMatch(TextBox9.Text))
            {

                System.Threading.Thread.Sleep(9000);

                Response.Redirect("http://localhost:50054/Formulario.aspx");
            }
        }



        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            Regex expressao3 = new Regex(@"^[0-9]");
            if (!expressao3.IsMatch(TextBox4.Text))
            {

                System.Threading.Thread.Sleep(9000);

                Response.Redirect("http://localhost:50054/Formulario.aspx");
            }
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {
            Regex expressao4 = new Regex(@"^[0-9]");
            if (!expressao4.IsMatch(TextBox5.Text))
            {

                System.Threading.Thread.Sleep(9000);

                Response.Redirect("http://localhost:50054/Formulario.aspx");
            }
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {
            Regex data = new Regex(@"^[0-9]{2}/[0-9]{2}/[0-9]{4}");
            if (!data.IsMatch(TextBox6.Text))
            {

                System.Threading.Thread.Sleep(9000);

                Response.Redirect("http://localhost:50054/Formulario.aspx");
            }

        }

        protected void TextBox10_TextChanged(object sender, EventArgs e)
        {
            Regex expressao8 = new Regex(@"^[0-9]");
            if (!expressao8.IsMatch(TextBox10.Text))
            {

                System.Threading.Thread.Sleep(9000);

                Response.Redirect("http://localhost:50054/Formulario.aspx");
            }


        }

        protected void Button8_Click(object sender, EventArgs e)
        {

         

            }



        protected void Button9_Click(object sender, EventArgs e)
        {

            string connectionString = @"Server=Localhost;Database=Consultorio;Trusted_Connection=true";
            SqlConnection conexao2 = new SqlConnection(connectionString);

            conexao2.Open();

            SqlCommand acha = new SqlCommand("select distinct DtConsulta,Dia_Consulta from Paciente_Clinica_Ilha where hora ='" + DropDownList2.Text + "' ", conexao2);

            DropDownList7.DataTextField = "Dia_Consulta";
            DropDownList7.DataValueField = "Dia_Consulta";
            DropDownList7.DataSource = acha.ExecuteReader();
            DropDownList7.DataBind();

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            
        }
        }
    }
        
        
        
    
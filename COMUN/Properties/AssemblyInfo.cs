using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// La información general sobre un ensamblado se controla mediante el siguiente 
// conjunto de atributos. Cambie estos atributos para modificar la información
// asociada con un ensamblado.
[assembly: AssemblyTitle("COMUN")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("COMUN")]
[assembly: AssemblyCopyright("Copyright ©  2015")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Si establece ComVisible como false, los tipos de este ensamblado no estarán visibles 
// para los componentes COM. Si necesita obtener acceso a un tipo de este ensamblado desde 
// COM, establezca el atributo ComVisible como true en este tipo.
[assembly: ComVisible(false)]

// El siguiente GUID sirve como identificador de typelib si este proyecto se expone a COM
[assembly: Guid("4ea94047-fcf8-46be-aae6-94d6ff33b6f6")]

// La información de versión de un ensamblado consta de los cuatro valores siguientes:
//
//      Versión principal
//      Versión secundaria 
//      Número de compilación
//      Revisión
//
// Puede especificar todos los valores o establecer como predeterminados los números de compilación y de revisión 
// mediante el carácter '*', como se muestra a continuación:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]


// Funciones de Javier Ramírez// //Nombres y fuentes: Fuente Bienvenido + Nombre AR CENA 20,25pt


//Variable para reconocer TextBox que ejecuto un evento//       
/*TextBox EsteControl = (TextBox)sender;
EsteControl.BackColor = Color.White;*/


/*
private bool VerificarTextboxvacios(TextBox textboxrecibido)
{
    if (!string.IsNullOrEmpty(textboxrecibido.Text)) //Comprueba si se encuentra vacío//
    {
        return true;
    }
    else
    {
        //Establecer Colores HEX//
        string hexColor = "#CA4444"; //Color TextBox error//
        Color mycolor = System.Drawing.ColorTranslator.FromHtml(hexColor); //Traductor HTML HeX
        textboxrecibido.BackColor = mycolor;
        return false;
    }

}*/

/*static public void colorerror(TextBox textboxrecibido)
{
    //Establecer Colores HEX//
    string hexColor = "#CA4444"; //Color TextBox error//
    Color mycolor = System.Drawing.ColorTranslator.FromHtml(hexColor); //Traductor HTML HeX
    textboxrecibido.BackColor = mycolor;
}*/

///Enviar MAIL///
/*private void (){ 
MailMessage mmsg = new MailMessage();
mmsg.To.Add(Mailglo2);
mmsg.Subject = "¡Nuevo Registro!";
mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
mmsg.Body = "Registro exitoso\n" + "Nombre: " + nombreglo2 + "\nDNI: " + DNIglo2 + "\nCUIT: " + cuitglo2 + "\nDomicilio: " + Domicilioglo2;
mmsg.BodyEncoding = System.Text.Encoding.UTF8;
mmsg.IsBodyHtml = false;
mmsg.From = new System.Net.Mail.MailAddress(mail);
System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
cliente.Credentials = new System.Net.NetworkCredential(mail, contraseña);
cliente.Port = 587;
cliente.EnableSsl = true;
cliente.Host = "smtp.gmail.com";
try
{
    cliente.Send(mmsg);
}
catch (Exception)
{
    MessageBox.Show("Error al enviar");

}



}*/
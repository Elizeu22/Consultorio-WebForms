



function expressao(string) {

    var recebe = document.getElementById(TextBox2);

    var  RegExp=/^[0-9]/;

    if (RegExp.test(recebe)==false) {
        document.write("DADO INVALDO");
    }
    
}
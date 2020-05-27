namespace Aula_POO_Celular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public int tamanho;
        public bool ligado;
        public bool desligado;

public bool Traduz(string condicao){
                if(condicao == "sim"){
                    ligado = true;
                }else{
                    ligado = false;
                }
                return ligado;
            }
/// <summary>
/// Saber se é possivel mandar mensagem
/// </summary>
/// <returns>Tela ligada ou não</returns>
public bool mensagem(){
    if(ligado == false){
        return ligado;
    }else{
        return ligado;
    }
}
/// <summary>
/// Saber se é possivel fazer ligação
/// </summary>
/// <returns>Tela ligada ou não</returns>
public bool ligacao(){
            if(ligado == false){
            return desligado;
            }else{
            return ligado;
            }
            
}
    }
}
namespace Aula_POO_Celular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public int tamanho;
        public bool ligado;
        public bool desligado;
        public bool mensagem;
        public bool ligacao;
/// <summary>
/// Saber se é possivel mandar mensagem
/// </summary>
/// <returns>Tela ligada ou não</returns>
public bool MandarMensagem(){
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
public bool FazerLigacao(){
            if(ligado == false){
            return desligado;
            }else{
            return ligado;
            }
}
/// <summary>
/// Enviar mensagem
/// </summary>
/// <returns>Texto de mensagem enviada</returns>
//public bool mensagem(){
    //if(ligado == true){
      //  return ligado;
    //}else{
        //return desligado;
    //}
//}

/// <summary>
/// Fazer ligação
/// </summary>
/// <returns>Texto de ligação feita</returns>
//public bool ligacao(){
  //  if(ligado == true){
    //    return ligado;
    //}else{
      //  return desligado;
  //  }
//}

    }
}
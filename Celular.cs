namespace CelularPoo
{
    public class Celular
    {
        //atributos

        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;

        //metodos

        /// <summary>
        /// ligar 
        /// </summary>
        /// <returns>ligando celualar</returns>
        public string Ligar(){
            ligado = true;
            return "Celular ligando";
        }

        /// <summary>
        /// desligar
        /// </summary>
        /// <returns>desligando celular</returns>
        public string Desligar(){
            ligado = false;
            return "desligando";
        }

        /// <summary>
        /// ligação
        /// </summary>
        /// <returns>fazer ligação</returns>
         public string FazerLigacao(){
            return "Fazendo ligacao";
        }

        /// <summary>
        /// mensagem
        /// </summary>
        /// <returns>enviar mensagem</returns>
         public string EnviarMensagem(){
            return "Enviando Mensagem";
        }
        
        



    }
}
using NHunspell;

namespace CorretorLib
{
    public class CorretorManager
    {
        public static CorretorResponse Verificar(string palavra)
        {
            var resposta = new CorretorResponse();

            using (Hunspell nuHunspell = new Hunspell("pt_br.aff", "pt_br.dic"))
            {
                resposta.IsCorreto = nuHunspell.Spell(palavra);

                if (!resposta.IsCorreto)
                {
                    resposta.Sugestoes = nuHunspell.Suggest(palavra);
                }
            }

            return resposta;
        }
    }
}

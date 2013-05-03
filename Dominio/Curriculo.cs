using System.Collections.Generic;

namespace Dominio
{
    public class Curriculo : EntidadeBase
    {
        public Candidato Candidato { get; set; }

        public ICollection<ExperienciaProfissional> ExperienciasProfissionais { get; set; }

        public ICollection<Instituicao> Instituicoes { get; set; }

        public ICollection<CursoDeExtencao> CursosDeExtencoes { get; set; }

        public ICollection<Idioma> Idiomas { get; set; }

        public void AdicionaExperienciaProfissional(ExperienciaProfissional experienciaProfissional)
        {
            if (!ExperienciasProfissionais.Contains(experienciaProfissional))
            {
                ExperienciasProfissionais.Add(experienciaProfissional);
            }
        }
        
        public void RemoveExperienciaProfissional(ExperienciaProfissional experienciaProfissional)
        {
            ExperienciasProfissionais.Remove(experienciaProfissional);
        }

        public void AdicionaInstituicao(Instituicao instituicao)
        {
            if (!Instituicoes.Contains(instituicao))
            {
                Instituicoes.Add(instituicao);
            }
        }
       
        public void RemoveInstituicao(Instituicao instituicao)
        {
            Instituicoes.Remove(instituicao);
        }

        public void AdicionaCursoDeExtencao(CursoDeExtencao cursoDeExtencao)
        {
            if(!CursosDeExtencoes.Contains(cursoDeExtencao))
            {
                CursosDeExtencoes.Add(cursoDeExtencao);
            }
        }

        public void RemoveCursoDeExtencao(CursoDeExtencao cursoDeExtencao)
        {
            CursosDeExtencoes.Remove(cursoDeExtencao);
        }

        public void AdiocinaIdioma(Idioma idioma)
        {
            if (!Idiomas.Contains(idioma))
            {
                Idiomas.Add(idioma);
            }
        }

        public void RemoveIdioma(Idioma idioma)
        {
            Idiomas.Remove(idioma);
        }
    }
}

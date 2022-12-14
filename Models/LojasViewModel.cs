namespace Avaliacao.Models;

public class LojasViewModel
{
    public int Id { get; set; }
    public string Piso { get; set; }
    public string Nome { get; set; }
    public string Tipo { get; set; }
    public string Descricao { get; set; }
    public string Email { get; set; }

    public LojasViewModel(int id, string piso, string nome, string tipo, string descricao, string email)
    {
        this.Id = id;
        this.Piso = piso;
        this.Nome = nome;
        this.Tipo = tipo;
        this.Descricao = descricao;
        Email = email;
    }
}
using UsuarioLib;

Usuario usuario = 
    new Usuario(
        "Daniel", 
        "daniel@email.com",
        new List<string>() {"12345678"});


//12345678
usuario.ExibeTelefones();

//efetuar a padronização
usuario.PadronizaTelefones();

//912345678
usuario.ExibeTelefones();

var coordenada = new Coordenada(123.123, -321.312);

Console.WriteLine(coordenada);

//////////////////

var dto = new FormularioDto();
dto.Nome = "Lucas";
dto.Idade = 18;

var dto2 = new FormularioDto();
dto.Nome = "Lucas";
dto.Idade = 18;

Console.WriteLine(dto == dto2);
-- SQLite
CREATE TABLE Livro(
IdLivro INT,
ISBNLivro varchar(80),
TituloLivro varchar(80),
PrecoLivro varchar(80),
CategoriaLivro varchar(10),
IdEditora INT,
PRIMARY KEY(IdLivro)
);

CREATE TABLE Editora(
IdEditora INT,
NomefantasiaEditora varchar(80),
RazaoSocialEditora varchar(80),
EnderecoEditora varchar(80),
TelefoneEditora varchar(10),
PRIMARY KEY(IdEditora)
);
👉 Miltec API - Backend

Este é o backend da aplicação de anúncios desenvolvida para o teste prático. 
O projeto foi desenvolvido utilizando C# e .NET, seguindo as melhores práticas e uma arquitetura em camadas.

📌 Tecnologias Utilizadas

- C# e .NET 6+ - Linguagem e framework principal.
- Entity Framework Core - ORM para manipulação do banco de dados.
- SQL Server - Banco de dados utilizado.
- Postman - Ferramenta para testar a API.
- ASP.NET Core Web API - Estrutura para criação da API REST.
- MediatR - Padrão para facilitar a comunicação entre camadas.

🚀 Como Rodar o Projeto

1️⃣ Clonando o Repositório

Para obter o código-fonte do projeto, execute o seguinte comando no terminal:

git clone https://github.com/seu-usuario/miltec-api.git
cd miltec-api

2️⃣ Pré-requisitos
- Antes de iniciar, certifique-se de ter instalado:
- SDK do .NET 6+
- SQL Server (ou utilize o SQL Server Express)
- Visual Studio 2022 ou VS Code
- Postman para testar os endpoints.

3️⃣ Rodando o Projeto

No terminal, dentro da pasta do projeto, execute:

cd MiltecApi


dotnet build


dotnet run

A API será iniciada e poderá ser acessada em http://localhost:5038


📌 Endpoints da API

🔹 1. Criar um Novo Anúncio

POST /api/anuncios

Exemplo de Requisição:

{
  "Nome": "Celular Samsung Galaxy S21",
  "DataPublicacao": "2024-01-31T14:30:00",
  "Valor": 2999.99,
  "Cidade": "São Paulo",
  "Tipo": "Eletrônico",
  "Categoria": null,
  "Modelo": "Galaxy S21",
  "Condicao": "Novo",
  "Quantidade": 5
}

🔹 2. Buscar Anúncio por ID

GET /api/anuncios/{id}

Exemplo: GET localhost:5038/api/anuncios/1

🔹 3. Listar Todos os Anúncios

GET /api/anuncios

Exemplo: GET localhost:5038/api/anuncios

🔹 4. Editar um Anúncio

PUT /api/anuncios/{id}

Exemplo de Requisição:

{
  "Id": 1,
  "Nome": "Celular Samsung Galaxy S21 editado",
  "DataPublicacao": "2024-01-31T14:30:00",
  "Valor": 2999.99,
  "Cidade": "São Paulo",
  "Tipo": "Eletrônico",
  "Categoria": null,
  "Modelo": "Galaxy S21",
  "Condicao": "usado",
  "Quantidade": 5
}

🔹 5. Excluir um Anúncio

DELETE /api/anuncios/{id}

Exemplo: DELETE localhost:5038/api/anuncios/1

🔗 Testando a API com Postman

Abra o Postman.

Importe a coleção JSON disponível no repositório, dentro da pasta Postman (MiltecApi.postman_collection.json).

Utilize os endpoints configurados na coleção para realizar as requisições.

Verifique as respostas e valide as operações da API.







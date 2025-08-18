# Plano de Ação: Implementar a API de Estoque

## Fase1: Construindo a API de Estoque

Vamos construir a API com o template de `Web API` do .NET, que já vem com uma estrutura básica para `APIs REST`, incluindo suporte a `Swagger (OpenAPI)` para documentação automática:

```bash
# Dentro da pasta 'src'
cd src
dotnet new webapi --name Stock.API
```

Agora, vamos adicionar o projeto à solução:

```bash
# Na raiz do projeto
dotnet sln add src/Stock.API/Stock.API.csproj
```

Ao final desta fase, você terá uma API funcional que pode ser executada, mas que ainda não faz nada específico do nosso e-commerce.

## Fase 2: Construindo o Microserviço de Estoque

Agora vamos implementar as funcionalidades descritas na ERS para o serviço de estoque.

1. **Definir o Modelo de Dados (Product)**: Crie uma classe que representará um produto no nosso sistema.

**Ação**: Dentro do projeto `Stock.API`, crie uma pasta `Models` e, dentro dela, um arquivo `Product.cs`.

```csharp 
// src/Stock.API/Models/Product.cs
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int QuantityInStock { get; set; }
}
```

2. **Configurar o Banco de Dados com Entity Framework (EF) Core**: O EF Core fará a "ponte" entre seus objetos C# e o banco de dados relacional.

**Ação**: Adicione os pacotes necessários ao projeto `Stock.API`. Execute os seguintes comandos a partir da **pasta raiz** do projeto:

```bash
dotnet add Stock.API.csproj package Microsoft.EntityFrameworkCore.SqlServer
dotnet add Stock.API.csproj package Microsoft.EntityFrameworkCore.Design
```

**Ação**: Crie o `DbContext`. Crie uma pasta `Data` e, dentro dela, um arquivo `StockDbContext.cs`.

```csharp
// src/Stock.API/Data/StockDbContext.cs
using Microsoft.EntityFrameworkCore;
using Stock.API.Models;

public class StockDbContext : DbContext
{
    public StockDbContext(DbContextOptions<StockDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
}
```

**Ação**: Configure a string de conexão no arquivo `appsettings.json` e registre o `DbContext` no `Program.cs`.

**VER: Com essas duas alterações, sua API agora está configurada para se comunicar com o banco de dados! O próximo passo lógico seria criar o banco de dados e a tabela Products usando as migrations do EF Core.**

1. **Criar o Controller da API de Produtos**: O `Controller` é a porta de entrada da sua API. Ele receberá as requisições HTTP (GET, POST, etc.) e orquestrará as ações.

**Ação**: Na pasta `Controllers`, crie um arquivo `ProductsController.cs`.
**Primeiro Endpoint (Cadastro de Produtos)**: Comece implementando o método para criar um novo produto. Isso corresponde ao primeiro item do roadmap!

```csharp
// src/Stock.API/Controllers/ProductsController.cs
using Microsoft.AspNetCore.Mvc;
using Stock.API.Data;
using Stock.API.Models;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly StockDbContext _context;

    public ProductsController(StockDbContext context)
    {
        _context = context;
    }

    // POST: api/products
    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] Product product)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();

        // Retorna o produto criado e um status 201 (Created)
        return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
    }

    // TODO: Implementar GetProductById, GetAllProducts, UpdateProduct, DeleteProduct
}
```

4. **Implementar os Demais Endpoints (CRUD)**: Com base no esqueleto acima, continue e implemente as outras operações:

- GET /api/products: Listar todos os produtos.
- GET /api/products/{id}: Consultar um produto específico pelo ID.
- PUT /api/products/{id}: Atualizar um produto.
- DELETE /api/products/{id}: Excluir um produto.

## Fase 3: Adicionando Qualidade e Boas Práticas

Com o CRUD básico funcionando, vamos adicionar os "Extras" mencionados na ERS.

1. **Implementar Testes Unitários**: Testes garantem que seu código funciona como esperado e evitam regressões no futuro.

**Ação**: Crie um projeto de testes na solução (ex: xUnit).

```bash
# Na raiz do projeto
dotnet new xunit --name Stock.API.Tests
dotnet sln add Stock.API.Tests/Stock.API.Tests.csproj
dotnet add Stock.API.Tests/Stock.API.Tests.csproj reference src/Stock.API/Stock.API.csproj
```

**Ação**: Escreva um primeiro teste para o endpoint de criação de produto, verificando se ele retorna o status 201 Created corretamente.

2. **Configurar Logs Básicos**: O .NET já possui um sistema de logging integrado. Comece a usá-lo para registrar informações importantes, como a criação de um novo produto ou a ocorrência de um erro.

**Ação**: No ProductsController, injete a interface ILogger e use-a para registrar eventos.

```csharp
// Exemplo de uso dentro de um método do controller
_logger.LogInformation("Novo produto criado com ID {ProductId}", product.Id);
```

## Próximos Passos (Visão de Futuro)

Depois de concluir essas três fases, você terá um microserviço de estoque robusto e bem testado. A partir daí, o caminho natural, seguindo a ERS, seria:

- Construir o Microserviço de Vendas, que irá consumir a `API` de Estoque que você acabou de criar.
- Implementar a Autenticação com `JWT` para proteger os endpoints.
- Configurar um `API Gateway` para ser o ponto de entrada único para os dois serviços.
- Integrar o `RabbitMQ` para a comunicação assíncrona entre os serviços de Venda e Estoque.

Este plano inicial fornece uma base sólida e alinhada com as melhores práticas de desenvolvimento. Comece pequeno, valide cada passo e construa a complexidade gradualmente.

Boa sorte e divirta-se codificando!

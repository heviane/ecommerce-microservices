# 2. Escolha do Banco de Dados Relacional

Date: 2024-05-21

## Status

Aceito

## Contexto

O projeto, conforme a [Especificação de Requisitos (ERS)](../especificacao-requisitos-ERS.md), necessita de um banco de dados relacional para persistir os dados dos microserviços, começando pelo serviço de Estoque. A escolha de uma tecnologia padrão é crucial para garantir consistência no desenvolvimento, nos testes e no ambiente de produção. As principais alternativas consideradas foram SQL Server, PostgreSQL e SQLite.

## Decisão

Adotaremos o **SQL Server** como o banco de dados relacional padrão para o projeto.

Para o ambiente de desenvolvimento local, a recomendação é executar o **SQL Server em um contêiner Docker**. Esta abordagem evita a instalação direta no sistema operacional, economiza espaço e garante um ambiente consistente para todos os desenvolvedores. A integração com a aplicação será feita através do provedor `Microsoft.EntityFrameworkCore.SqlServer` do Entity Framework Core.

## Consequências

### Positivas:

- **Integração Nativa**: Sendo um produto da Microsoft, o SQL Server possui a integração mais fluida e documentada com o ecossistema .NET e o Entity Framework Core.
- **Ferramental Robusto**: Desenvolvedores podem usar ferramentas gratuitas e poderosas como o SQL Server Management Studio (SSMS) ou a extensão oficial para Visual Studio Code.
- **Curva de Aprendizado Reduzida**: É a escolha mais comum em tutoriais e documentações do .NET, o que facilita a pesquisa e a resolução de problemas para desenvolvedores iniciantes.
- **Alinhamento com o Plano**: A decisão se alinha perfeitamente com o plano de ação inicial, que já previa a instalação do pacote `Microsoft.EntityFrameworkCore.SqlServer`.

### Negativas:

- **Acoplamento ao Ecossistema Microsoft**: Embora seja possível rodar em outras plataformas via Docker, a solução é menos agnóstica a sistema operacional quando comparada com alternativas como o PostgreSQL.

### Alternativas Consideradas:

- **PostgreSQL**: Uma alternativa open-source extremamente robusta e com excelente suporte do EF Core. Foi preterida neste momento para simplificar a configuração inicial e maximizar a sinergia com o restante da stack .NET, evitando qualquer atrito adicional para a equipe.
- **SQLite**: Considerado muito simplista para o desenvolvimento de uma arquitetura de microserviços que visa simular um ambiente de produção. Seu uso será avaliado futuramente para a execução de testes unitários em memória.

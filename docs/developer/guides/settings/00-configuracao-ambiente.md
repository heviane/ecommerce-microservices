# Guia 00: Configuração do Ambiente de Desenvolvimento

Este guia detalha o software e as ferramentas que você precisa instalar em sua máquina para contribuir com o projeto **ecommerce-microservices**. Seguir estes passos garantirá que você tenha um ambiente de desenvolvimento consistente e pronto para o trabalho.

## Pré-requisitos

Antes de começar, certifique-se de que você tem permissões de administrador na sua máquina para instalar os softwares necessários.

A lista de ferramentas essenciais é:

1. **Git**: Para controle de versão do código.
2. **.NET 9 SDK**: A plataforma de desenvolvimento para construir os microserviços.
3. **Docker Desktop**: Para executar serviços em contêineres, como nosso banco de dados SQL Server.
4. **Um Editor de Código/IDE**: Recomendamos o Visual Studio Code por ser leve e poderoso.

---

## Instalação Passo a Passo

### 1. Git

O Git é fundamental para clonar o repositório e gerenciar as versões do código.

- **Download**: Acesse [git-scm.com](https://git-scm.com/downloads) e baixe o instalador para o seu sistema operacional (Windows, macOS ou Linux).
- **Instalação**: Siga as instruções do instalador. As opções padrão são geralmente suficientes.

### 2. .NET 9 SDK

Usamos o .NET 9 para desenvolver nossas APIs. É importante instalar o **SDK (Software Development Kit)**, que inclui o runtime e as ferramentas de linha de comando.

- **Download**: Acesse a [página de download do .NET 9](https://dotnet.microsoft.com/download/dotnet/9.0).
- **Instalação**: Baixe e execute o instalador do .NET SDK para sua plataforma.

### 3. Docker Desktop

O Docker nos permite executar o SQL Server e outros serviços em um ambiente isolado, garantindo consistência entre as máquinas dos desenvolvedores.

- **Download**: Acesse a [página do Docker Desktop](https://www.docker.com/products/docker-desktop/).
- **Instalação**: Baixe e instale o Docker Desktop. Pode ser necessário reiniciar o computador. No Windows, ele pode exigir a ativação do WSL 2.

### 4. Visual Studio Code (Recomendado)

O VS Code é um editor de código gratuito e altamente extensível que funciona bem com C# e .NET.

- **Download**: Acesse [code.visualstudio.com](https://code.visualstudio.com/).
- **Instalação**: Siga as instruções de instalação.
- **Extensões Recomendadas**: Após instalar o VS Code, abra-o e instale as seguintes extensões para uma melhor experiência de desenvolvimento .NET:
  - `ms-dotnettools.csdevkit`: O C# Dev Kit oficial da Microsoft, que agrupa C#, IntelliCode e mais.
  - `ms-azuretools.vscode-docker`: Para gerenciar contêineres Docker diretamente do editor.

---

## Verificação do Ambiente

Após instalar tudo, abra um novo terminal ou PowerShell e execute os seguintes comandos para verificar se cada ferramenta foi instalada corretamente. Você deve ver a versão de cada uma delas sem erros.

```bash
git --version
# Exemplo de saída: git version 2.41.0

dotnet --version
# Exemplo de saída: 8.0.300

docker --version
# Exemplo de saída: Docker version 26.1.1
```

---

## Configurando o Projeto Localmente

Com o ambiente pronto, vamos clonar o projeto e iniciar o banco de dados.

1. **Clone o repositório**:

```bash
git clone https://github.com/heviane/ecommerce-microservices.git
cd ecommerce-microservices
```

1. **Inicie o Banco de Dados (SQL Server)**:

O projeto agora inclui um arquivo `docker-compose.yml` na raiz para simplificar a inicialização do banco de dados. Execute o seguinte comando na raiz do projeto:

```bash
docker-compose up -d
```

Este comando irá baixar a imagem do SQL Server (se ainda não a tiver) e iniciará um contêiner em segundo plano (`-d`). O banco de dados estará acessível na porta `1433` da sua máquina local.

Parabéns! Seu ambiente está configurado e pronto. Agora você pode abrir a pasta do projeto no Visual Studio Code e começar a desenvolver.

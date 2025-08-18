# Plano de Ação: Inicializando o projeto

Aqui está um guia detalhado para orientar o desenvolvimento inicial.

> **Plano de ação**: é um guia prático de Implementação, um tutorial passo a passo.
> Ele é sobre **execução**, não sobre decisão. Serve para documentar o "COMO".

## Fase 1: Preparando o Terreno (Estrutura do Projeto)

O objetivo aqui é criar a estrutura básica da solução.

1. **Criar a Solução (.sln)**: Uma solução no `.NET` agrupa vários projetos.

Como teremos mais de um microserviço, é uma boa prática começar com uma solução.

```bash
# Na raiz do projeto (ecommerce-microservices)
dotnet new sln --name Ecommerce.Microservices
```

Após a execução deste comando, será criado um arquivo com a extensão `.sln`.

2. **Criar o diretório `src`**: Este diretório será usado para abrigar o código fonte do projeto, que será versionado e compartilhado com Git e GitGub.

```bash
mkdir src
```

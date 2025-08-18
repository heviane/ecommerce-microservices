# Roadmap do Projeto

Este documento descreve as principais features e melhorias planejadas para o futuro do projeto **ecommerce-microservices**.

As ideias aqui são de alto nível. Quando uma feature estiver pronta para ser desenvolvida, ela será detalhada em uma ou mais [Issues do GitHub](https://github.com/heviane/ecommerce-microservices/issues).

## Próximas Versões (Short-term)

- **[X] Implementar CRUD completo da API de Estoque**: Criar os endpoints RESTful para cadastrar, consultar, atualizar e excluir produtos.
  - **Guias de Implementação**:
    - [Guia 00: Implementando uma Solução DotNet](./guides/plans/00-implementacao-solucao-dotnet.md)
    - [Guia 01: Implementando a API de Estoque](./guides/01-implementando-api-estoque.md)

- **[ ] Testar o CRUD da API de Estoque**: Testar a implementação acima.
  - **Guias de Teste**: TODO....

### Extras da Especificação de Requisitos

- **[ ] Implementar Testes Unitários**: Criar testes unitários para as funcionalidades principais, como cadastro de produtos e criação de pedidos.
- **[ ] Implementar Monitoramento e Logs**: Implementar monitoramento básico de logs para rastrear falhas e transações no sistema.
- **[ ] Implementar Escalabilidade**: O sistema deve ser capaz de escalar facilmente, caso seja necessário adicionar mais microserviços (ex: microserviço de pagamento ou de envio).

## Futuro (Long-term)

- **[ ] Melhorar Monitoramento e Logs**: Implementar uma solução de logging estruturado (ex: Serilog) e centralização de logs (ex: ELK Stack, Seq) para facilitar o rastreamento de transações e erros entre os microserviços.
- **[ ] Implementar Testes de Integração**: Criar testes que validem a comunicação e o fluxo de ponta a ponta entre os microserviços (Vendas -> Estoque).
- **[ ] Implementar Microserviço de Pagamentos**: Criar um serviço dedicado para processar pagamentos, integrando com gateways de pagamento externos.
- **[ ] Implementar Microserviço de Notificações**: Desenvolver um serviço para enviar notificações (e-mail, SMS) aos clientes sobre o status de seus pedidos (pedido recebido, pagamento aprovado, enviado, etc.).
- **[ ] Sistema de Avaliação de Produtos**: Permitir que os clientes avaliem e comentem sobre os produtos que compraram.
- **[ ] Cache de Produtos**: Implementar uma camada de cache (ex: Redis) no serviço de Estoque para acelerar a consulta de produtos e reduzir a carga no banco de dados.

## Ideias em Análise

- **[ ] Orquestração de Contêineres**: Estudar a implementação do projeto usando Docker e orquestração com Kubernetes para facilitar o deploy e a escalabilidade.
- **[ ] Refatorar Autenticação**: Mover a lógica de geração e validação de JWT para um serviço de identidade dedicado ou para o API Gateway, em vez de mantê-la em cada microserviço.

---

*Este roadmap é um documento vivo e está sujeito a mudanças com base nas prioridades e necessidades do projeto.*

# E-commerce Microservices API

[![Deploy Documentation](https://github.com/heviane/ecommerce-microservices/actions/workflows/deploy-docs.yml/badge.svg)](https://github.com/heviane/ecommerce-microservices/actions/workflows/deploy-docs.yml)

API de microsserviços para e-commerce altamente escalável construída com .NET Core, projetada para gerenciar estoque e vendas de forma eficiente.

## 📖 Documentação

Toda a documentação detalhada do projeto, incluindo guias para desenvolvedores e usuários, está disponível em nosso site de documentação.

### **[Acesse a documentação completa aqui](https://heviane.github.io/ecommerce-microservices/)**

## Sobre o Projeto

O projeto consiste em uma aplicação com arquitetura de microserviços para gerenciamento de estoque de produtos e vendas em uma plataforma de e-commerce.

O sistema é composto por dois microserviços principais:

- **Gestão de Estoque**: Gerencia o catálogo de produtos e suas quantidades.
- **Gestão de Vendas**: Gerencia os pedidos dos clientes.

A comunicação entre os serviços é feita via API Gateway, com eventos assíncronos gerenciados pelo RabbitMQ.

## ✨ Principais Tecnologias

- .NET Core (C#)
- RESTful API
- Entity Framework
- RabbitMQ
- JWT (JSON Web Tokens)
- MkDocs para documentação

## 🥇 Licença

Este projeto está licenciado sob a Licença MIT. Veja o arquivo [LICENSE](./LICENSE) para mais detalhes.

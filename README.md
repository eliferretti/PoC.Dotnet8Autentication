# 🔐 PoC .NET 8 Authentication

Proof of Concept (PoC) desenvolvida em .NET 8 com foco na implementação de autenticação e autorização utilizando JWT (JSON Web Token).

O objetivo deste projeto é demonstrar uma estrutura moderna de autenticação para aplicações ASP.NET Core, aplicando boas práticas de segurança, gerenciamento de usuários e proteção de endpoints.

---

# 🚀 Tecnologias Utilizadas

* .NET 8
* ASP.NET Core Web API
* JWT Authentication
* ASP.NET Identity
* Entity Framework Core
* SQL Server
* Swagger / OpenAPI
* C#
* Dependency Injection

---

# 🎯 Objetivo da POC

Esta Proof of Concept foi criada para validar e demonstrar:

* Cadastro de usuários
* Login autenticado
* Geração de JWT Token
* Autorização baseada em token
* Proteção de rotas
* Controle de acesso
* Integração com Identity
* Estrutura moderna de autenticação no .NET 8

---

# 🏗 Arquitetura

A aplicação foi organizada seguindo separação de responsabilidades e boas práticas do ecossistema .NET.

```text
PoC.Dotnet8Authentication
│
├── Controllers
├── Services
├── Interfaces
├── Models
├── DTOs
├── Data
├── Configurations
└── Migrations
```

---

# 🔑 Fluxo de Autenticação

```text
Usuário
   │
   ▼
Login
   │
   ▼
Validação Credenciais
   │
   ▼
Geração JWT
   │
   ▼
Token Retornado
   │
   ▼
Acesso a Endpoints Protegidos
```

---

# 📦 Funcionalidades

### Usuário

* Registro de usuário
* Login
* Validação de credenciais
* Geração de Token JWT

### Segurança

* Autenticação Bearer Token
* Proteção de endpoints
* Controle de autorização
* Expiração de token

---

# ⚙️ Pré-requisitos

Antes de executar o projeto:

* .NET 8 SDK
* SQL Server
* Visual Studio 2022 ou VS Code
* Git

---

# 🔧 Instalação

Clone o repositório:

```bash
git clone https://github.com/eliferretti/PoC.Dotnet8Autentication.git
```

Acesse a pasta:

```bash
cd PoC.Dotnet8Autentication
```

Restaure os pacotes:

```bash
dotnet restore
```

---

# 🗄 Banco de Dados

Aplicar migrations:

```bash
dotnet ef database update
```

Criar migration:

```bash
dotnet ef migrations add InitialCreate
```

---

# ▶️ Executando o Projeto

```bash
dotnet run
```

A API ficará disponível em:

```text
https://localhost:5001
```

ou

```text
http://localhost:5000
```

---

# 📖 Swagger

Após iniciar a aplicação:

```text
https://localhost:5001/swagger
```

A documentação permitirá testar endpoints diretamente pela interface.

---

# 🔐 Exemplo de Fluxo JWT

### Registro

```http
POST /api/auth/register
```

Exemplo:

```json
{
  "name": "Usuário Teste",
  "email": "usuario@email.com",
  "password": "Senha@123"
}
```

---

### Login

```http
POST /api/auth/login
```

Exemplo:

```json
{
  "email": "usuario@email.com",
  "password": "Senha@123"
}
```

Resposta:

```json
{
  "token": "jwt-token-gerado"
}
```

---

### Utilização do Token

Header:

```http
Authorization: Bearer {token}
```

---

# 🛡 Conceitos Aplicados

* JWT (JSON Web Token)
* Authentication
* Authorization
* Identity Management
* Secure API Design
* Dependency Injection
* Clean Code
* SOLID Principles

---

# 📚 Aprendizados

Durante o desenvolvimento desta POC foram explorados:

* Configuração de autenticação no .NET 8
* Emissão e validação de JWT
* Segurança em APIs REST
* Proteção de recursos utilizando Authorize
* Integração com ASP.NET Identity
* Gerenciamento de usuários e permissões

---

# 👨‍💻 Autor

Eli Ferretti

GitHub:
https://github.com/eliferretti

---

# 📄 Licença

Projeto desenvolvido para fins de estudo, aprendizado e validação de estratégias de autenticação em aplicações ASP.NET Core.
